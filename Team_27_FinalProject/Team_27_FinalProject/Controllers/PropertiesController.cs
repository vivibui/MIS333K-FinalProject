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

    public class PropertiesController : Controller
    {
        private readonly AppDbContext _context;

        public PropertiesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Properties
        public async Task<IActionResult> Index()
        {
            return View(await _context.Properties.ToListAsync());
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
                .Include(c => c.AppUser)
                .FirstOrDefaultAsync(m => m.PropertyID == id);

            //product was not found in the database
            if (property == null)
            {
                return View("Error", new String[] { "That product was not found in the database." });
            }

            return View(property);
        }




        //--------------------------------- CREATE -------------------------------------
        //Only Host can create propert
        [Authorize(Roles = "Host")]
        // GET: Properties/Create
        public IActionResult Create()
        {
            return View();
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

            //if code gets this far, add the property to the database
            _context.Add(property);
            await _context.SaveChangesAsync();

            return View();
        }



        //--------------------------------- EDIT -------------------------------------
        //Only Admin and Host can access
        [Authorize(Roles = "Admin, Host")]
        // GET: Properties/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @property = await _context.Properties.FindAsync(id);
            if (@property == null)
            {
                return NotFound();
            }
            return View(@property);
        }

        // POST: Properties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PropertyID,PropertyNumber,Street,City,State,Zip,Bedrooms,Bathrooms,PetsAllowed,GuestsAllowed,ParkingFree,IsDiscounted,WeekDayPrice,WeekendPrice,DiscountMinNights,DiscountRate,CleaningFee")] Property @property)
        {
            if (id != @property.PropertyID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@property);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PropertyExists(@property.PropertyID))
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
            return View(@property);
        }

        //Property Exists Method
        private bool PropertyExists(int id)
        {
            return _context.Properties.Any(e => e.PropertyID == id);
        }
    }
}
