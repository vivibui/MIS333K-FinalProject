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
using Team_27_FinalProject.SendMail;
using Microsoft.AspNetCore.Identity;

namespace Team_27_FinalProject.Controllers
{

    public class PropertiesController : Controller
    {
        private SignInManager<AppUser> _signInManager;
        private readonly AppDbContext _context;

        public PropertiesController(AppDbContext context)
        {
            _context = context;
        }


        //--------------------------------- CUSTOMER: GET ALL ACTIVE PROPERTIES -------------------------------------
        // GET: Properties for customer to view (Only active and approved ones) 
        public ActionResult Index()
        {
            var query = from p in _context.Properties
                        select p;

            query = query.Where(p => p.PStatus == 0 && p.IsDisabled == false);

            //.ToList() method to execute the query. Include statement to get the navigational data
            List<Property> ActiveProperties = query.Include(p => p.Category)
                                                    .Include(p => p.Reviews)
                                                    .ToList();

            return View(ActiveProperties);
        }


        //--------------------------------- ADMIN: VIEW AND DECIDE ON NEWLY CREATED PROPERTIES -------------------------------------
        // GET: Properties for admin to approve or reject newly created properties 
        [Authorize(Roles = "Admin")]
        public IActionResult PendingCreateAdminViewIndex()
        {
            var query = from p in _context.Properties
                        select p;

            query = query.Where(p => p.PStatus == Property.PropertyStatus.Pending);

            //.ToList() method to execute the query. Include statement to get the navigational data
            List<Property> PendingProperties = query.Include(p => p.Category)
                                                    .Include(p => p.AppUser)
                                                    .ToList();

            return View(PendingProperties);
        }

        [Authorize(Roles = "Admin")]
        // GET DETAILS
        [HttpGet]
        public IActionResult PendingCreateAdminView(int? id)
        {
            //if the user didn't specify a property id, we can't show them 
            //the data, so show an error instead
            if (id == null)
            {
                return View("Error", new string[] { "Please specify a property to edit!" });
            }

            //find the property in the database
            //be sure to change the data type to property instead of 'var'
            Property property = _context.Properties.Include(p => p.Category)
            .FirstOrDefault(p => p.PropertyID == id);

            //if the property does not exist in the database, then show the user
            //an error message
            if (property == null)
            {
                return View("Error", new string[] { "This property was not found!" });
            }

            return View(property);

        }

        // POST DETAILS
        [HttpPost]
        public async Task<IActionResult> PendingCreateAdminView(int id, string button, Property property)
        {
            //this is a security check to make sure they are editing the correct record
            if (id != property.PropertyID)
            {
                return View("Error", new String[] { "There was a problem editing this record. Try again!" });
            }

            //information is not valid, try again
            if (ModelState.IsValid == false)
            {
                return View(property);
            }

            //create a new property
            Property dbRD;
            //if code gets this far, update the record
            try
            {
                //find the existing property in the database
                //include all nav. properties
                dbRD = _context.Properties
                      .Include(p => p.Category)
                      .Include(p => p.Reviews)
                      .Include(p => p.AppUser)
                      .FirstOrDefault(p => p.PropertyID == property.PropertyID);

                //update property status
                if (button.ToLower() == "approve")
                {
                    dbRD.PStatus = property.PStatus = Property.PropertyStatus.Approved;
                }
                else if (button.ToLower() == "reject")
                {
                    dbRD.PStatus = property.PStatus = Property.PropertyStatus.Rejected;

                }

                //save changes
                _context.Update(dbRD);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was a problem editing this record", ex.Message });
            }

            //if code gets this far, go back to view list of all active properties 
            return RedirectToAction("Index", "Properties");
        }


        //--------------------------------- DETAIL -------------------------------------
        // GET: Properties/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            //id was not specified - show the user an error
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a property to view!" });
            }

            //find the property in the database
            //be sure to include the relevant navigational data
            Property property = await _context.Properties
                .Include(p => p.Category).Include(p => p.Reviews)
                .FirstOrDefaultAsync(m => m.PropertyID == id);

            //product was not found in the database
            if (property == null)
            {
                return View("Error", new String[] { "That product was not found in the database." });
            }

            return View(property);
        }




        //--------------------------------- HOST: CREATE NEW LISTING -------------------------------------
        //Only Host can create propert
        [Authorize(Roles = "Host")]
        // GET: Properties/Create
        public IActionResult Create()
        {
            ViewBag.AllCategories = GetAllCategories();
            return View();
        }

        private SelectList GetAllCategories()
        {
            //Get the list of categories from the database
            List<Category> categoryList = _context.Categories.ToList();

            //convert the list to a SelectList by calling SelectList constructor
            //CategoryID and CategoryName are the names of the properties on the Cateogry class
            //CategoryID is the primary key
            SelectList categorySelectList = new SelectList(categoryList.OrderBy(m => m.CategoryID), "CategoryID", "CategoryName");

            //return the electList
            return categorySelectList;
        }

        // POST: Properties/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PropertyID,PropertyNumber,Street,City,State,Zip,Bedrooms,Bathrooms,PetsAllowed,GuestsAllowed,ParkingFree,IsDiscounted,WeekDayPrice,WeekendPrice,DiscountMinNights,DiscountRate,CleaningFee")] Property property)
        {

            //Find the next property number from the utilities class
            property.PropertyNumber = Utilities.GenerateNextPropertyNumber.GetNextPropertyNumber(_context);

            //Associate the registration with the logged-in customer
            property.AppUser = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);

            //make sure all properties are valid
            if (ModelState.IsValid == false)
            {
                return View(property);
            }

            //if code gets this far:

            //Assign status as pending
            property.PStatus = Property.PropertyStatus.Pending;
            
            //Add to DB 
            _context.Add(property);
            await _context.SaveChangesAsync();

            ViewBag.ConfirmCreate = property;

            return View("ConfirmCreate");
        }



        //--------------------------------- ADMIN: EDIT ALL PROPERTY (INCLUDING DISABLE) -------------------------------------
        //Only Admin can access
        [Authorize(Roles = "Admin")]
        // GET: Properties/Edit/5
        public IActionResult Edit(int? id)
        {
            //if the user didn't specify a property id, we can't show them 
            //the data, so show an error instead
            if (id == null)
            {
                return View("Error", new string[] { "Please specify a property to edit!" });
            }

            //find the property in the database
            //be sure to change the data type to property instead of 'var'
            Property property = _context.Properties.Include(p => p.Category)
            .FirstOrDefault(p => p.PropertyID == id);

            //if the property does not exist in the database, then show the user
            //an error message
            if (property == null)
            {
                return View("Error", new string[] { "This property was not found!" });
            }

            return View(property);

        }

        // POST: Properties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PropertyID,PropertyNumber,Street,City,State,Zip,Bedrooms,Bathrooms,PetsAllowed,GuestsAllowed,ParkingFree,IsDiscounted,WeekDayPrice,WeekendPrice,DiscountMinNights,DiscountRate,CleaningFee")] Property @property)
        {
            //this is a security check to make sure they are editing the correct record
            if (id != property.PropertyID)
            {
                return View("Error", new String[] { "There was a problem editing this record. Try again!" });
            }

            //information is not valid, try again
            if (ModelState.IsValid == false)
            {
                return View(property);
            }

            //create a new property
            Property dbRD;
            //if code gets this far, update the record
            try
            {
                //find the existing property in the database
                //include both order and product
                dbRD = _context.Properties
                      .Include(p => p.Category)
                      .Include(p => p.Reviews)
                      .Include(p => p.AppUser)
                      .FirstOrDefault(p => p.PropertyID == property.PropertyID);

                //save changes
                _context.Update(dbRD);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was a problem editing this record", ex.Message });
            }

            //if code gets this far, go back to the property index page
            return View();
        }

        //Property Exists Method
        private bool PropertyExists(int id)
        {
            return _context.Properties.Any(e => e.PropertyID == id);
        }


        //--------------------------------- HOST: EDIT LISTED PROPERTIES (INCLUDING DISABLE) -------------------------------------

    }
}
