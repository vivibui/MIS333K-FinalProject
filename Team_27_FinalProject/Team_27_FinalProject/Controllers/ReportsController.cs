using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_27_FinalProject.DAL;
using Team_27_FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace Team_27_FinalProject.Controllers
{
    [Authorize(Roles = "Host, Admin")]
    public class ReportsController : Controller
    {
        
        //private UserManager<AppUser> _userManager;

        private AppDbContext _context;
        public ReportsController(AppDbContext dbContext)
        {
            _context = dbContext;
        }


        // GET: Home
        //-------------------------- INDEX: ONLY LIST COMPLETED RESERVATIONS -------------------------- 
        public ActionResult Index()
        {
            var query = from r in _context.Reservations
                        select r;

            var query1 = from p in _context.Properties
                         select p;

            //.ToList() method to execute the query. Include statement to get the navigational data
            //List<Reservation> SelectedReservations = query.Include(r => r.Property).ToList();

            //Set up a list of orders to display
            List<Reservation> SelectedReservations = new List<Reservation>();
            if (User.IsInRole("Admin"))
            {
                SelectedReservations = _context.Reservations
                                .Include(r => r.Property)
                                .ToList();
            }
            else //user is a host, so only display their records
            {
                SelectedReservations = _context.Reservations
                                .Include(r => r.Property)
                                .ThenInclude(r => r.AppUser)
                                .Where(r => r.Property.AppUser.UserName == User.Identity.Name)
                                .ToList();
            }

            //Populate the view bag with a count of all reservations
            ViewBag.AllReservations = _context.Reservations.Count();
            //Populate the view bag with a count of selected properties
            ViewBag.SelectedReservations = SelectedReservations.Count;


            return View(SelectedReservations);
        }



        //-------------------------- DETAILS: SHOW DETAILS OF A RESERVATION  -------------------------- 

        public IActionResult Details(int? id)//id is the id of the property you want to see
        {
            if (id == null) //ReservationID not specified
            {
                //user did not specify a PropertyID – take them to the error view
                return View("Error", new String[] { "ReservationID not specified - which reservation do you want to view?" });
            }
            //look up the property in the database based on the id; be sure to include the category
            Reservation reservation = _context.Reservations.Include(p => p.Property)
            .FirstOrDefault(r => r.ReservationID == id);
            if (reservation == null) //No reservation with this id exists in the database
            {
                //there is not a reservation with this id in the database – show the user an error view
                return View("Error", new String[] { "Reservation not found in database" });
            }
            //if code gets this far, all is well – display the details
            return View(reservation);
        }



        //--------------------------------- DETAILED SEARCH  ----------------------------------- 

        public IActionResult DetailedSearch()
        {

            //populate viewbag with list of properties
            ViewBag.AllProperties = GetAllProperties();

            //set default properties
            ReportViewModel rvm = new ReportViewModel();

            rvm.SelectedPropertyID = 0;

            return View(rvm);
        }


        //--------------------------------- GET ALL PROPERTIES  ----------------------------------- 

        private SelectList GetAllProperties()
        {

            ////Find the logged in user using the UserManager
            //var userLoggedIn = await _userManager.FindByNameAsync(User.Identity.Name);

            ////Get the list of properties from the database
            ////assign the list of properties to the host
            List<Property> propertyList = _context.Properties.ToList();


            //var query1 = from p in _context.Properties
            //            select p;

            //query1 = query1.Where(p => p.AppUser.Email == userLoggedIn.Email);

            ////.ToList() method to execute the query. Include statement to get the navigational data
            //List<Property> propertyList = query1.Include(r => r.AppUser)
            //                                        .ToList();


            //Set up a list of orders to display
            //List<Property> propertyList = new List<Property>();
            //if (User.IsInRole("Admin"))
            //{
            //    propertyList = _context.Properties
            //                    .ToList();
            //}
            //else //user is a host, so only display their records
            //{
            //    propertyList = _context.Properties
            //                    .Where(o => o.AppUser.UserName == User.Identity.Name)
            //                    .ToList();
            //}

            //add a dummy entry so the user can select all properties
            Property SelectNone = new Property() { PropertyID = 0, PropertyNumber = 0 };
            propertyList.Add(SelectNone);

            //convert the list to a SelectList by calling SelectList constructor
            //CategoryID and CategoryName are the names of the properties on the Category class

            SelectList propertySelectList = new SelectList(propertyList.OrderBy(p => p.PropertyID), "PropertyID", "PropertyNumber");

            //return the SelectList
            return propertySelectList;
        }

        //--------------------------------- DISPLAY SEARCH RESULT  ----------------------------------- 

        public IActionResult DisplaySearchResults(ReportViewModel rvm)
        {
            var query = from r in _context.Reservations
                        select r;
            var query1 = from p in _context.Properties
                         select p;


            ViewBag.AllProperties = GetAllProperties();

            //SEARCH BY PROPERTY
            if (rvm.SelectedPropertyID != 0)
            {
                query = query.Where(r => r.Property.PropertyID == rvm.SelectedPropertyID);
            }

            //SEARCH BY EVENUE (exact, minimum, maximum, both)
            if (rvm.SelectedRevenue != null)
            {
                query = query.Where(r => r.HostRevenue == rvm.SelectedRevenue);
            }

            if (rvm.SelectedMinRevenue != null)
            {
                query = query.Where(r => r.HostRevenue >= rvm.SelectedMinRevenue);
            }

            if (rvm.SelectedMaxRevenue != null)
            {
                query = query.Where(r => r.HostRevenue <= rvm.SelectedMaxRevenue);
            }

            if (rvm.SelectedMinRevenue != null && rvm.SelectedMaxRevenue != null)
            {
                query = query.Where(r => r.HostRevenue >= rvm.SelectedMinRevenue && r.HostRevenue <= rvm.SelectedMaxRevenue);
            }


            //SEARCH BY CLEANING FEE (exact, min, max, or both)
            if (rvm.SelectedCleaning != null)
            {
                query = query.Where(r => r.CleaningPrice == rvm.SelectedCleaning);
            }

            if (rvm.SelectedMinCleaning != null)
            {
                query = query.Where(r => r.CleaningPrice >= rvm.SelectedMinCleaning);
            }

            if (rvm.SelectedMaxCleaning != null)
            {
                query = query.Where(r => r.CleaningPrice <= rvm.SelectedMaxCleaning);
            }

            if (rvm.SelectedMinCleaning != null && rvm.SelectedMaxCleaning != null)
            {
                query = query.Where(r => r.CleaningPrice >= rvm.SelectedMinCleaning && r.CleaningPrice <= rvm.SelectedMaxCleaning);
            }

            //SEARCH BY TOTAL EARNING
            if (rvm.SelectedEarning != null)
            {
                query = query.Where(r => r.TotalEarning == rvm.SelectedEarning);
            }

            if (rvm.SelectedMinEarning != null)
            {
                query = query.Where(r => r.TotalEarning >= rvm.SelectedMinEarning);
            }

            if (rvm.SelectedMaxEarning != null)
            {
                query = query.Where(r => r.TotalEarning <= rvm.SelectedMaxEarning);
            }

            if (rvm.SelectedMinEarning != null && rvm.SelectedMaxEarning != null)
            {
                query = query.Where(r => r.TotalEarning >= rvm.SelectedMinEarning && r.TotalEarning <= rvm.SelectedMaxEarning);
            }


            //SEARCH BY START AND END DATE
            if (rvm.SelectedStartDate != null)
            {
                query = query.Where(r => (r.CheckinDate >= rvm.SelectedStartDate) || (r.CheckoutDate >= rvm.SelectedStartDate));
            }

            if (rvm.SelectedEndDate != null)
            {
                query = query.Where(r => (r.CheckinDate <= rvm.SelectedEndDate) || (r.CheckoutDate <= rvm.SelectedEndDate));
            }

            if (rvm.SelectedStartDate != null && rvm.SelectedEndDate != null)
            {
                query = query.Where(r => (r.CheckinDate >= rvm.SelectedStartDate) || (r.CheckoutDate >= rvm.SelectedStartDate) || (r.CheckinDate <= rvm.SelectedEndDate) || (r.CheckoutDate <= rvm.SelectedEndDate));
            }

            



            //.ToList() method to execute the query. Include statement to get the navigational data
            List<Reservation> SelectedReservations = query.Include(r => r.Property).ToList();

            //Populate the view bag with a count of all reservations
            ViewBag.AllReservations = _context.Reservations.Count();
            //Populate the view bag with a count of selected reservations
            ViewBag.SelectedReservations = SelectedReservations.Count;

            //Return the view with SelectedProperties
            return View("Index", SelectedReservations);

        }
    }
}
