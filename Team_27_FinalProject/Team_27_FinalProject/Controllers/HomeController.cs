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
        //constructor to get an instance of the AppDbContext
        private AppDbContext _context;
        public HomeController(AppDbContext dbContext)
        {
            _context = dbContext;
        }

        //pull data from database
        public IActionResult Index()
        {
            //var query = from p in _context.Properties
              //          select p;
            //if (SearchString is not null)
            {
             //   query = query.Where(b => b.Title.Contains(SearchString) ||
b.Description.Contains(SearchString));
            }

            //.ToList() method to execute the query. Include statement to get the navigational data
            //List<Book> SelectedBooks = query.Include(b => b.Genre).ToList();

            //Populate the view bag with a count of all properties
            ViewBag.AllProperties = _context.Properties.Count();
            //Populate the view bag with a count of selected properties
            ViewBag.SelectedProperties = SelectedProperties.Count;

            //Return the view with SelectedBooks. OrderBy sorts the results by title
            return View(_context.Properties.Include(s => s.Categories).ToList()); ;
        }


        //allow the user to see details of a property
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
    }
}
