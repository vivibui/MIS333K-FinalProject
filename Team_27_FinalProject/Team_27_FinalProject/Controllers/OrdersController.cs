using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Team_27_FinalProject.DAL;
using Team_27_FinalProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Team_27_FinalProject.Utilities;
using Team_27_FinalProject.SendMail;

namespace Team_27_FinalProject.Controllers
{
    //Only logged-in users can access orders
    [Authorize]

    public class OrdersController : Controller
    {

        private UserManager<AppUser> _userManager;

        private readonly AppDbContext _context;

        public OrdersController(AppDbContext context)
        {
            _context = context;
        }


        //------------------------------------- INDEX --------------------------------------

        // GET: Orders
        public IActionResult Index()
        {
            //Set up a list of orders to display
            List<Order> orders = new List<Order>();
            if (User.IsInRole("Admin"))
            {
                orders = _context.Orders
                                .Include(o => o.Reservations)
                                .ToList();
            }
            else //user is a customer, so only display their records
            {
                orders = _context.Orders
                                .Include(o => o.Reservations)
                                .Where(o => o.AppUser.UserName == User.Identity.Name)
                                .ToList();
            }

            return View(orders);
        }


        //------------------------------------- DETAILS --------------------------------------

        // GET: Orders/Details/5
        public IActionResult Details(int? id)
        {
            //The user did not specify a order to view 
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a order to view!" });
            }

            //Find the order in the database 
            Order order = _context.Orders
                .Include(ord => ord.Reservations)
                .ThenInclude(ord => ord.Property)
                .Include(ord => ord.AppUser)
                .FirstOrDefault(o => o.OrderID == id);

            //Order was not found in the database 
            if (order == null)
            {
                return View("Error", new String[] { "This order was not found!" });
            }

            //Make sure a customer isn't trying to look at someone else's order
            if (User.IsInRole("Admin") == false && order.AppUser.UserName != User.Identity.Name)
            {
                return View("Error", new string[] { "You are not authorized to edit this order!" });
            }

            //Send user to the details page 
            return View(order);
        }

        //------------------------------------- CART --------------------------------------

        public IActionResult UserCart(int? id)
        {
            //Get the associated property
            Property property = _context.Properties
                                       .Include(p => p.Reservations)
                                       .ThenInclude(p => p.Order)
                                       .Include(p => p.AppUser)
                                       .FirstOrDefault(p => p.PropertyID == id);

            Order cart = Cart.GetCart(_context, User.Identity.Name, property);

            return View(cart);
        }

        //------------------------------------- CREATE --------------------------------------

        // GET: Orders/Create
        //add checkin and checkout dates 
        [Authorize(Roles ="Customer")]
        public IActionResult Create(int? id)
        {
            //Get the associated property
            Property property = _context.Properties
                                       .Include(p => p.Reservations)
                                       .ThenInclude(p => p.Order)
                                       .Include(p => p.AppUser)
                                       .FirstOrDefault(p => p.PropertyID == id);

            Order order = Cart.GetCart(_context, User.Identity.Name, property);

            return RedirectToAction ("DetailedSearch", "Home");
        }

        //Test
        public async Task<IActionResult> ConfirmOrder (int id, Order order)
        {
            //---------VALIDATE 

            //Create a viewbag
            ViewBag.OrderNumber = order.OrderNumber;

            //make sure all properties are valid
            if (ModelState.IsValid == false)
            {
                return View(order);
            }

            //---------SET ORDER STATUS
            order.OStatus = Order.OrderStatus.Completed; 

            //if code gets this far, add the order to the database
            _context.Add(order);
            await _context.SaveChangesAsync();

            //Find the next order number from the utilities class
            order.OrderNumber = Utilities.GenerateNextOrderNumber.GetNextOrderNumber(_context);

            //Send Email
            String emailSubject = "Your New Reservation has been received.";
            String emailBody = @"<div> Hi " + order.AppUser.FirstName + ",</div><br/>";
            emailBody = emailBody + @"<div>Your confirmation number is </div>" + order.OrderNumber;
            emailBody = emailBody + @"<br/><div> Enjoy your upcoming trip! </div>";

            EmailMessaging.SendEmail(order.AppUser.Email, emailSubject, emailBody);

            return View("OrderConfirm");

        }



        //------------------------------------- EDIT --------------------------------------

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //user did not specify an order to edit
            if (id == null)
            {
                return View("Error", new String[] { "Please specify an order to edit" });
            }

            //find the order in the database, and be sure to include reservations
            Order order = _context.Orders
                                       .Include(o => o.Reservations)
                                       .ThenInclude(o => o.Property)
                                       .Include(o => o.AppUser)
                                       .FirstOrDefault(o => o.OrderID == id);

            //order was nout found in the database
            if (order == null)
            {
                return View("Error", new String[] { "This order was not found in the database!" });
            }

            //order does not belong to this user
            if (User.IsInRole("Customer") && order.AppUser.UserName != User.Identity.Name)
            {
                return View("Error", new String[] { "You are not authorized to edit this order!" });
            }

            //send the user to the order edit view
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderID")] Order order)
        {
            //this is a security measure to make sure the user is editing the correct order
            if (id != order.OrderID)
            {
                return View("Error", new String[] { "There was a problem editing this order. Try again!" });
            }

            //if there is something wrong with this order, try again
            if (ModelState.IsValid == false)
            {
                return View(order);
            }
            //create a new order
            Order dbO;

            //if code gets this far, update the record
            try
            {
                //find the existing order in the database
                dbO = _context.Orders
                      .Include(o => o.Reservations)
                      .ThenInclude(o => o.Property)
                      .Include(o => o.AppUser)
                      .FirstOrDefault(o => o.OrderID == order.OrderID);

                //save changes
                _context.Update(dbO);
                await _context.SaveChangesAsync();

                //find the record in the database
                Order dbOrder = _context.Orders.Find(order.OrderID);

                _context.Update(dbOrder);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was an error updating this order!", ex.Message });
            }

            //send the user to the Order Index page.
            return RedirectToAction(nameof(Index));
        }
    }
}
