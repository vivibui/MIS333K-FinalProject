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
using Team_27_FinalProject.Utilities;

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



        //------------------------------------------ HOST: LOCK DATES  ------------------------------------------
        // GET: Reservations/LockDate
        [Authorize(Roles="Host")]
        public IActionResult LockDate(int? id)
        {

            //Validate booking
            if (id == null)
            {
                return View("Error", new string[] { "Please specify a property to reserve!" });
            }


            //find the property in the database
            Property property = _context.Properties.Include(p => p.Category)
                                                    .FirstOrDefault(p => p.PropertyID == id);

            //Pass the IDs to the viewmodel 
            var model = new Booking
            {
                //OrderID = dbOrder.OrderID,
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
        public async Task<IActionResult> LockDate(int PropertyID, LockDate lockDate)
        {
            //if user has not entered all fields, send them back to try again
            if (ModelState.IsValid == false)
            {

                return View("Booking");
            }

            //find the property to be associated with this order
            Property dbProperty = _context.Properties.Find(lockDate.PropertyID);


            //----- CHECK IF DATE SELECTED IS LESS THAN DATE TODAY 
            if (lockDate.StartDate <= System.DateTime.Now || lockDate.EndDate <= System.DateTime.Now)
            {
                ModelState.AddModelError("Past Date", "Date selected must be greater than today.");
                return View(lockDate);
            }

            //----- CHECK IF CHECKOUT IS LESS THAN CHECKIN DATE 
            if (lockDate.EndDate <= lockDate.StartDate)
            {
                ModelState.AddModelError("Less Than", "Checkout date must be greater than checkin date");
                return View(lockDate);

            }

            //--------------------VALIDATE IF CHECK IN IS TODAY ----------------
            if (lockDate.StartDate == DateTime.Now)
            {
                ModelState.AddModelError("Not Today", "You cannot create a reservation with a checkin is today.");
                return View(lockDate);
            }


            //--------------------IF CODE GET THIS FAR: 

            //create a new instance of the Reservation class
            Reservation rs = new Reservation();

            //Pass values from Booking view model to this instance
            rs.CheckinDate = lockDate.StartDate;
            rs.CheckoutDate = lockDate.EndDate;

            //set the reservation's property
            rs.Property = dbProperty;

            //Set the status
            rs.RStatus = Reservation.ReservationStatus.Incoming;

            //add the reservation to the database
            _context.Add(rs);
            await _context.SaveChangesAsync();

            //send the user to the details page for this order
            return RedirectToAction("Index", "Orders", new { id = rs.Order.OrderID });
        }


        // GET: Reservations/Create
        public IActionResult Booking(int? id)
        {

            //Validate booking
            if (id == null)
            {
                return View("Error", new string[] { "Please specify a property to reserve!" });
            }


            //find the property in the database
            Property property = _context.Properties.Include(p => p.Category)
                                                    .FirstOrDefault(p => p.PropertyID == id);

            //Pass the IDs to the viewmodel 
            var model = new Booking
            {
                //OrderID = dbOrder.OrderID,
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
        public async Task<IActionResult> Booking(int PropertyID, Booking booking)
        {
            //if user has not entered all fields, send them back to try again
            if (ModelState.IsValid == false)
            {

                return View("Booking");
            }

            //find the property to be associated with this order
            Property dbProperty = _context.Properties.Find(booking.PropertyID);


            //----- CHECK IF DATE SELECTED IS LESS THAN DATE TODAY 
            if (booking.CheckinDate <= System.DateTime.Now || booking.CheckoutDate <= System.DateTime.Now)
            {
                ModelState.AddModelError("Past Date", "Date selected must be greater than today.");
                return View(booking);
            }

            //----- CHECK IF CHECKOUT IS LESS THAN CHECKIN DATE 
            if (booking.CheckoutDate <= booking.CheckinDate)
            {
                ModelState.AddModelError("Less Than", "Checkout date must be greater than checkin date");
                return View(booking);

            }

            //--------------------VALIDATE IF CHECK IN IS TODAY ----------------
            if (booking.CheckinDate == DateTime.Now)
            {
                ModelState.AddModelError("Not Today", "You cannot create a reservation with a checkin is today.");
                return View(booking);
            }


            //--------------------VALIDATE THE NUMBER OF GUESTS----------------
            if (booking.NumberOfGuests > dbProperty.GuestsAllowed)
            {
                ModelState.AddModelError("Overcrowded", "The entered guests number is over the host allowed maximum of guests.");
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
            Order dbOrder = Cart.GetCart(_context, User.Identity.Name);

            //set the order on the reservation equal to the order that we just found
            rs.Order = dbOrder;

            //set the reservation's price equal to the property price
            //this will allow us to to store the price that the user paid
            rs.WeekdayFee = dbProperty.WeekDayPrice;
            rs.WeekendFee = dbProperty.WeekendPrice;
            rs.CleaningPrice = dbProperty.CleaningFee;



            //------------------------------- VALIDATE CHECKIN CHECKOUT TIME (DUPLICATION) -------------------------------
            rs.Property = _context.Properties.FirstOrDefault(p => p.PropertyID == rs.Property.PropertyID);

            //see if available
            //search for dates
            var dateQuery = from r in _context.Reservations select r;

            //find reservations outside of the desired range - these are okay reservations
            dateQuery = dateQuery.Include(r => r.Property).Where(r => r.CheckinDate >= rs.CheckoutDate || r.CheckoutDate <= rs.CheckinDate);

            //execute the query
            List<Reservation> reservations = dateQuery.ToList();

            //the list we found is the okay reservations - we need the problems
            List<Reservation> unavailable = _context.Reservations.Include(r => r.Property).ToList().Except(reservations).ToList();  //all reservations that cause problems


            //see if any of the problem reservations are from the property we are trying to reserve

            unavailable = unavailable.Where(r => r.Property.PropertyID == rs.Property.PropertyID).ToList();


            //if any of these reservations are a problem, then show an error

            if (unavailable.Count > 0)
            {
                return View("Error", new string[] { "This property is not available for your dates." });
            }



            //-------------------CALCULATION------------------

            //Get list of dates 
            List<DateTime> allDates = new List<DateTime>();
            for (DateTime i = rs.CheckinDate; i < rs.CheckoutDate; i = i.AddDays(1))
            {
                allDates.Add(i);
            }
            //Calculate
            Int32 TotalWeekdays = 0;
            Int32 TotalWeekends = 0;
            foreach (var item in allDates)
            {
                if (item.DayOfWeek == DayOfWeek.Friday || item.DayOfWeek == DayOfWeek.Saturday)
                {
                    TotalWeekends = TotalWeekends + 1;
                }
                else
                {
                    TotalWeekdays = TotalWeekdays + 1;
                }
            }
            rs.StayPrice = (TotalWeekdays * rs.WeekdayFee) + (TotalWeekends * rs.WeekendFee);

            //Set the status
            rs.RStatus = Reservation.ReservationStatus.Incoming;

            //add the reservation to the database
            _context.Add(rs);
            await _context.SaveChangesAsync();

            //send the user to the details page for this order
            return RedirectToAction("Details", "Orders", new { id = rs.Order.OrderID });
        }

        private bool ReservationExists(int id)
        {
            return _context.Reservations.Any(e => e.ReservationID == id);
        }
    }
}
