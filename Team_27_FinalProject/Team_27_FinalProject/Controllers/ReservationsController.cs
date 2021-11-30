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
    //Only logged-in users can make reservation
    [Authorize]

    public class ReservationsController : Controller
    {
        private readonly AppDbContext _context;

        public ReservationsController(AppDbContext context)
        {
            _context = context;
        }



        //------------------------------------------ INDEX ------------------------------------------
        // GET: Reservations
        public IActionResult Index(int? orderID)
        {
            if (orderID == null)
            {
                return View("Error", new String[] { "Please specify an order to view!" });
            }

            //limit the list to only the reservation that belong to this order
            List<Reservation> rs = _context.Reservations
                                          .Include(rs => rs.Property)
                                          .Where(rs => rs.Order.OrderID == orderID)
                                          .ToList();

            return View(rs);
        }



        //------------------------------------------
        // GET: Reservations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations
                .FirstOrDefaultAsync(m => m.ReservationID == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }



        //------------------------------------------ CREATE ------------------------------------------
        // GET: Reservations/Create
        public IActionResult Create(int orderID)
        {
            //create a new instance of the Reservation class
            Reservation rs = new Reservation();

            //find the reservation that should be associated with this order
            Order dbOrder = _context.Orders.Find(orderID);

            //set the new reservation's order equal to the order you just found
            rs.Order = dbOrder;

            //populate the ViewBag with a list of existing properties
            ViewBag.AllProducts = GetAllProperties();

            //pass the newly created reservation to the view
            return View(rs);
        }


        // ADD: GetAllProperties
        private SelectList GetAllProperties()
        {
            //create a list for all the properties
            List<Property> allProperties = _context.Properties.ToList();

            //the user MUST select a property, so you don't need a dummy option for no product

            //use the constructor on select list to create a new select list with the options
            SelectList slAllProperties = new SelectList(allProperties, nameof(Property.PropertyID), nameof(Property.Street));

            return slAllProperties;
        }


        // POST: Reservations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReservationID,CheckinDate,CheckoutDate,NumberOfGuests,CleaningPrice,WeekdayFee,WeekendFee,StayPrice,IsDisabled,Discount")] Reservation reservation, int SelectedProperty)
        {
            //if user has not entered all fields, send them back to try again
            if (ModelState.IsValid == false)
            {
                ViewBag.AllProducts = GetAllProperties();
                return View(reservation);
            }

            //find the property to be associated with this order
            Property dbProperty = _context.Properties.Find(SelectedProperty);

            //set the reservation's property to be equal to the one we just found
            reservation.Property = dbProperty;

            //find the order on the database that has the correct order id
            //unfortunately, the HTTP request will not contain the entire order object, 
            //just the order id, so we have to find the actual object in the database
            Order dbOrder = _context.Orders.Find(reservation.Order.OrderID);

            //set the order on the reservation equal to the order that we just found
            reservation.Order = dbOrder;

            //set the reservation's price equal to the property price
            //this will allow us to to store the price that the user paid
            reservation.WeekdayFee = dbProperty.WeekDayPrice;
            reservation.WeekendFee = dbProperty.WeekendPrice;
            reservation.CalStayPrice();

            //add the reservation to the database
            _context.Add(reservation);
            await _context.SaveChangesAsync();

            //send the user to the details page for this order
            return RedirectToAction("Details", "Orders", new { id = reservation.Order.OrderID });
        }

        //------------------------------------------ EDIT ------------------------------------------



        // GET: Reservations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }
            return View(reservation);
        }

        // POST: Reservations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReservationID,CheckinDate,CheckoutDate,NumberOfGuests,CleaningPrice,WeekdayFee,WeekendFee,StayPrice,IsDisabled,Discount")] Reservation reservation)
        {
            if (id != reservation.ReservationID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reservation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservationExists(reservation.ReservationID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(reservation);
        }

        private bool ReservationExists(int id)
        {
            return _context.Reservations.Any(e => e.ReservationID == id);
        }
    }
}
