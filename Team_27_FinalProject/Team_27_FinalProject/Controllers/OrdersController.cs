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

namespace Team_27_FinalProject.Controllers
{
    //Only logged-in users can access orders
    [Authorize]

    public class OrdersController : Controller
    {
        private readonly AppDbContext _context;

        public OrdersController(AppDbContext context)
        {
            _context = context;
        }

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

            //
            return View(orders);
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            //the user did not specify an order to view
            if (id == null)
            {
                return View("Error", new String[] { "Please specify an order to view!" });
            }

            //find the order in the database
            Order order = await _context.Orders
                                              .Include(o => o.Reservations)
                                              .ThenInclude(o => o.Property)
                                              .Include(o => o.AppUser)
                                              .FirstOrDefaultAsync(o => o.OrderID == id);

            //order was not found in the database
            if (order == null)
            {
                return View("Error", new String[] { "This order was not found!" });
            }

            //make sure this order belongs to this user
            if (User.IsInRole("Customer") && order.AppUser.UserName != User.Identity.Name)
            {
                return View("Error", new String[] { "This is not your order!  Don't be such a snoop!" });
            }

            //Send the user to the details page
            return View(order);
        }

        // GET: Orders/Create
        //add checkin and checkout dates 
        [Authorize(Roles ="Customer")]
        public IActionResult Create()
        {
            return RedirectToAction ("DetailedSearch", "Home");
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //[Authorize(Roles ="Customer")]
        ////TODO: what to bind?
        //public async Task<IActionResult> Create([Bind("OrderID")] Order order)
        //{
        //    //Find the next order number from the utilities class
        //    order.OrderNumber = Utilities.GenerateNextOrderNumber.GetNextOrderNumber(_context);

        //    //Set the date of this order
        //    order.OrderDate = DateTime.Now;

        //    //Associate the order with the logged-in customer
        //    order.AppUser = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);

        //    //make sure all properties are valid
        //    if (ModelState.IsValid == false)
        //    {
        //        return View(order);
        //    }

        //    //if code gets this far, add the order to the database
        //    _context.Add(order);
        //    await _context.SaveChangesAsync();

        //    //send the user on to the action that will allow them to 
        //    //create a reservation.  Be sure to pass along the orderID
        //    //that you created when you added the order to the database above
        //    return RedirectToAction("Create", "Reservations", new { orderID = order.OrderID });
        //}

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

            //if code gets this far, update the record
            try
            {
                //find the record in the database
                Order dbOrder = _context.Orders.Find(order.OrderID);

                //update the notes
                //dbOrder.OrderNotes = order.OrderNotes;

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
