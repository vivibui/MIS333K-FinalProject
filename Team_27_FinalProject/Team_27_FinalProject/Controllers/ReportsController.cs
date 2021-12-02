using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_27_FinalProject.DAL;
using Team_27_FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Team_27_FinalProject.Controllers
{
    public class ReportsController : Controller
    {
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

            //query = query.Where(r => r.ReservationStatus.Completed == true);

            //.ToList() method to execute the query. Include statement to get the navigational data
            List<Reservation> SelectedReservations = query.Include(r => r.Property).ToList();

            //Populate the view bag with a count of all reservations
            ViewBag.AllReservations = _context.Reservations.Count();
            //Populate the view bag with a count of selected properties
            ViewBag.SelectedReservations = SelectedReservations.Count;


            return View(SelectedReservations);
        }



        //-------------------------- DETAILS: SHOW DETAILS OF A RESERVATION/REPORT  -------------------------- 

        //public IActionResult Details(int? id)//id is the id of the property you want to see
        //{
        //    if (id == null) //PropertyID not specified
        //    {
        //        //user did not specify a PropertyID – take them to the error view
        //        return View("Error", new String[] { "PropertyID not specified - which property do you want to view?" });
        //    }
        //    //look up the property in the database based on the id; be sure to include the category
        //    Property property = _context.Properties.Include(r => r.Reservations)
        //    .FirstOrDefault(p => p.PropertyID == id);
        //    if (property == null) //No property with this id exists in the database
        //    {
        //        //there is not a property with this id in the database – show the user an error view
        //        return View("Error", new String[] { "Property not found in database" });
        //    }
        //    //if code gets this far, all is well – display the details
        //    return View(property);
        //}



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
            //Get the list of categories from the database
            List<Property> propertyList = _context.Properties.ToList();

            //add a dummy entry so the user can select all genres
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
