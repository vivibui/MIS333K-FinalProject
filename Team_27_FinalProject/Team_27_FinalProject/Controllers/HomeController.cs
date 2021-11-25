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
        public ActionResult Index()
        {
            return View();
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


        public IActionResult DetailedSearch()
        {
            //populate viewbag with list of category
            ViewBag.AllCategories = GetAllCategories();

            //set default properties
            SearchViewModel svm = new SearchViewModel();

            svm.SelectedCategoryID = 0;

            return View(svm);
        }

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
    }
}
