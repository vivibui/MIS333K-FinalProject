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
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext dbContext)
        {
            _context = dbContext;
        }

        // GET: Home
        //-------------------------- INDEX: ONLY LIST ACTIVE PROPERTY -------------------------- 
        public ActionResult Index()
        {
            var query = from p in _context.Properties
                        select p;

            query = query.Where(p => p.PStatus == 0 && p.IsDisabled == false);

            //.ToList() method to execute the query. Include statement to get the navigational data
            List<Property> SelectedProperties = query.Include(p => p.Category).Include(p => p.Reviews).ToList();

            //Populate the view bag with a count of all properties
            ViewBag.AllProperties = _context.Properties.Count();
            //Populate the view bag with a count of selected properties
            ViewBag.SelectedProperties = SelectedProperties.Count;


            return View(SelectedProperties);
        }



        //-------------------------- DETAILS: SHOW DETAILS OF A PROPERTY  -------------------------- 

        public IActionResult Details(int? id)//id is the id of the property you want to see
        {
            if (id == null) //PropertyID not specified
            {
                //user did not specify a PropertyID – take them to the error view
                return View("Error", new String[] { "PropertyID not specified - which property do you want to view?" });
            }
            //look up the property in the database based on the id; be sure to include the category
            Property property = _context.Properties.Include(p => p.Category)
            .FirstOrDefault(p => p.PropertyID == id);
            if (property == null) //No property with this id exists in the database
            {
                //there is not a property with this id in the database – show the user an error view
                return View("Error", new String[] { "Property not found in database" });
            }
            //if code gets this far, all is well – display the details
            return View(property);
        }




        //--------------------------------- DETAILED SEARCH  ----------------------------------- 

        public IActionResult DetailedSearch()
        {

            //populate viewbag with list of category
            ViewBag.AllCategories = GetAllCategories();

            //set default properties
            SearchViewModel svm = new SearchViewModel();

            svm.SelectedCategoryID = 0;

            return View(svm);
        }




        //--------------------------------- GET ALL CATEGORIES  ----------------------------------- 

        private SelectList GetAllCategories()
        {
            //Get the list of categories from the database
            List<Category> categoryList = _context.Categories.ToList();

            //add a dummy entry so the user can select all genres
            //Genre SelectNone = new Genre() { GenreID = 0, GenreName = "All Genres" };
            //genreList.Add(SelectNone);

            //convert the list to a SelectList by calling SelectList constructor
            //CategoryID and CategoryName are the names of the properties on the Category class

            SelectList categorySelectList = new SelectList(categoryList.OrderBy(c => c.CategoryID), "CategoryID", "CategoryName");

            //return the SelectList
            return categorySelectList;
        }




        //--------------------------------- DISPLAY SEARCH RESULT  ----------------------------------- 

        public IActionResult DisplaySearchResults(SearchViewModel svm)
        {
            var query = from p in _context.Properties
                        select p;
            var query1 = from r in _context.Reservations
                         select r;

            ViewBag.AllCategories = GetAllCategories();
            //-----SEARCH BY CITY
            if (String.IsNullOrEmpty(svm.SelectedCity) == false)
            {
                query = query.Where(p => p.City.Contains(svm.SelectedCity));
            }

            //-----SEARCH BY STATE
            if (String.IsNullOrEmpty(svm.SelectedState) == false)
            {
                query = query.Where(p => p.State.Contains(svm.SelectedState));
            }

            //-----SEARCH BY BEDROOMS
            if (svm.SelectedBedrooms != null)
            {
                query = query.Where(p => p.Bedrooms == svm.SelectedBedrooms);
            }

            if (svm.SelectedMinBedrooms != null)
            {
                query = query.Where(p => p.Bedrooms >= svm.SelectedMinBedrooms);
            }

            if (svm.SelectedMaxBedrooms != null)
            {
                query = query.Where(p => p.Bedrooms <= svm.SelectedMaxBedrooms);
            }

            if (svm.SelectedMinBedrooms != null && svm.SelectedMaxBedrooms != null)
            {
                query = query.Where(p => p.Bedrooms >= svm.SelectedMinBedrooms && p.Bedrooms <= svm.SelectedMaxBedrooms);
            }

            //-----SEARCH BY BATHROOMS
            if (svm.SelectedBathrooms != null)
            {
                query = query.Where(p => p.Bathrooms == svm.SelectedBathrooms);
            }

            if (svm.SelectedMinBathrooms != null)
            {
                query = query.Where(p => p.Bathrooms >= svm.SelectedMinBathrooms);
            }

            if (svm.SelectedMaxBathrooms != null)
            {
                query = query.Where(p => p.Bathrooms <= svm.SelectedMaxBathrooms);
            }

            if (svm.SelectedMinBathrooms != null && svm.SelectedMaxBathrooms != null)
            {
                query = query.Where(p => p.Bathrooms >= svm.SelectedMinBathrooms && p.Bathrooms <= svm.SelectedMaxBathrooms);
            }

            //-----SEARCH BY CATEGORY
            if (svm.SelectedCategoryID != 0)
            {
                query = query.Where(p => p.Category.CategoryID == svm.SelectedCategoryID);
            }

            //-----SEARCH BY GUEST LIMIT
            if (svm.SelectedGuests != null)
            {
                query = query.Where(p => p.GuestsAllowed >= svm.SelectedGuests);
            }

            //-----SEARCH BY PETS ALLOWED
            if (svm.SelectedPets == true)
            {
                query = query.Where(p => p.PetsAllowed == true);
            }

            //-----SEARCH BY PARKING
            if (svm.SelectedParking == true)
            {
                query = query.Where(p => p.ParkingFree == true);
            }


            //-----SEARCH BY PRICE
            if (svm.SelectedWeekdayPrice != null)
            {
                query = query.Where(p => p.WeekDayPrice <= svm.SelectedWeekdayPrice);
            }

            if (svm.SelectedWeekendPrice != null)
            {
                query = query.Where(p => p.WeekendPrice <= svm.SelectedWeekendPrice);
            }

            if (svm.SelectedBothPrices != null)
            {
                query = query.Where(p => p.WeekDayPrice <= svm.SelectedBothPrices && p.WeekendPrice <= svm.SelectedBothPrices);
            }


            



            //-----SEARCH BY RATING
            if (svm.SelectedRating != null)
            {
                if (svm.RatingType == RatingType.LessThan)
                {
                    query = query.Where(p => (p.Reviews.Average(r => r.Rating) < svm.SelectedRating) ||
                                            (p.Reviews.Count() ==0)
                                        );
                }
                else
                {
                    query = query.Where(p => p.Reviews.Average(r => r.Rating) > svm.SelectedRating);
                }
            }




            //-------------------------- SEARCH BY DATES --------------------------
            //Search by Dates
            if (svm.SelectedCheckin != null && svm.SelectedCheckout != null)
            {

                //----- CHECK IF DATE SELECTED IS LESS THAN DATE TODAY 
                if (svm.SelectedCheckin <= System.DateTime.Now || svm.SelectedCheckout <= System.DateTime.Now)
                {
                    ModelState.AddModelError("Past Date", "Date selected must be greater than today.");
                    return View("DetailedSearch",svm);
                }

                //----- CHECK IF CHECKOUT IS LESS THAN CHECKIN DATE 
                if (svm.SelectedCheckout < svm.SelectedCheckin)
                {
                    ModelState.AddModelError("Less Than", "Checkout date must be greater than checkin date");
                    return View("DetailedSearch",svm);

                }

                query1 = query1.Where(r => (r.CheckoutDate <= svm.SelectedCheckin && svm.SelectedCheckin <= r.CheckinDate) || (r.CheckinDate >= svm.SelectedCheckout && r.CheckinDate <= svm.SelectedCheckin));


                List<Reservation> reservations = query1.ToList();
                var query3 = from p in _context.Properties select p;
                foreach (Reservation res in reservations)
                {
                    query3 = query3.Where(p => p.Reservations.Any(r => r.ReservationID == res.ReservationID));
                }

                List<Property> Unavailable = query3.ToList();

            }


            //.ToList() method to execute the query. Include statement to get the navigational data
            List<Property> SelectedProperties = query.Include(p => p.Category).Include(p => p.Reviews).ToList();

            //Populate the view bag with a count of all properties
            ViewBag.AllProperties = _context.Properties.Count();
            //Populate the view bag with a count of selected properties
            ViewBag.SelectedProperties = SelectedProperties.Count;

            //Return the view with SelectedProperties
            return View("Index", SelectedProperties);
        }
    }
}
