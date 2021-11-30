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



        //------------------------------------------ DETAILS ------------------------------------------
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



        //------------------------------------------ CREATE RESERVATION ------------------------------------------
        // GET: Reservations/Create
        public IActionResult Booking(int? propertyID, int orderID)
        {

            //Validate booking
            if (propertyID == null)
            {
                return View("Error", new string[] { "Please specify a property to reserve!" });
            }

            //find the associated order
            Order dbOrder = _context.Orders.Find(orderID);

            //find the property in the database
            Property property = _context.Properties.Include(p => p.Category)
            .FirstOrDefault(p => p.PropertyID == propertyID);

            //Pass the IDs to the viewmodel 
            var model = new Booking
            {
                OrderID = dbOrder.OrderID,
                PropertyID = property.PropertyID
            };

            //pass the newly created reservation to the view
            return View(model);
        }


        // POST: Reservations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReservationID,CheckinDate,CheckoutDate,NumberOfGuests,CleaningPrice,WeekdayFee,WeekendFee,StayPrice,IsDisabled,Discount")] Booking booking)
        {
            //if user has not entered all fields, send them back to try again
            if (ModelState.IsValid == false)
            {

                return View("Booking");
            }

            //find the property to be associated with this order
            Property dbProperty = _context.Properties.Find(booking.PropertyID);


            //------------------VALIDATE CHECKIN CHECKOUT TIME-----------------

            var unavailableRes = _context.Reservations
                                         .Where(r => r.Property.PropertyID == booking.PropertyID &&
                                                (booking.CheckinDate <= r.CheckoutDate && booking.CheckinDate >= r.CheckinDate ||
                                                    r.CheckinDate <= booking.CheckoutDate && r.CheckinDate >= booking.CheckinDate))
                                         .ToList();

            //Initialize empty list
            List<DateTime> CheckRange = new List<DateTime>(); //empty list for booking
            List<DateTime> GetDates = new List<DateTime>(); // empty list for all dates in reservation

            //Add all dates between checkout and checkin to list 
            for (DateTime i = booking.CheckinDate; i <= booking.CheckoutDate; i = i.AddDays(1))
            {
                CheckRange.Add(i);
            }

            //Loop to add dates to Get Dates 
            foreach (var res in unavailableRes)
            {
                for (DateTime i = res.CheckinDate; i <= res.CheckoutDate; i = i.AddDays(1))
                {
                    GetDates.Add(i);
                }
            }

            //Loop to compare the dates in Booking and unavailableRes 
            foreach (var date in GetDates)
            {
                foreach (var bookdate in CheckRange)
                {
                    if (bookdate == date)
                    {
                        ModelState.AddModelError("Booking unsuccessful.", "The entered date range has already been reserved.");
                        return View(booking);
                    }
                }
            }



            //--------------------VALIDATE THE NUMBER OF GUESTS----------------
            if (booking.NumberOfGuests > dbProperty.GuestsAllowed)
            {
                ModelState.AddModelError("Overcrowded.", "The entered guests number is over the host allowed maximum of guests.");
                return View(booking);
            }


            //--------------------IF CODE GET THIS FAR: 

            //create a new instance of the Reservation class
            Reservation rs = new Reservation();

            //Pass values from Booking view model to this instance
            rs.CheckinDate = booking.CheckinDate;
            rs.CheckoutDate = booking.CheckoutDate;
            rs.NumberOfGuests = booking.NumberOfGuests;

            //set the reservation's property
            rs.Property = dbProperty;

            //find the order on the database that has the correct order id
            //unfortunately, the HTTP request will not contain the entire order object, 
            //just the order id, so we have to find the actual object in the database
            Order dbOrder = _context.Orders.Find(rs.Order.OrderID);

            //set the order on the reservation equal to the order that we just found
            rs.Order = dbOrder;

            //set the reservation's price equal to the property price
            //this will allow us to to store the price that the user paid
            rs.WeekdayFee = dbProperty.WeekDayPrice;
            rs.WeekendFee = dbProperty.WeekendPrice;
            rs.CleaningPrice = dbProperty.CleaningFee;
            rs.CalStayPrice();

            //add the reservation to the database
            _context.Add(rs);
            await _context.SaveChangesAsync();

            //send the user to the details page for this order
            return RedirectToAction("Details", "Orders", new { id = rs.Order.OrderID });
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
