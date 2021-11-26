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
using Microsoft.AspNetCore.Identity;
using Team_27_FinalProject.Utilities;

namespace Team_27_FinalProject.Controllers
{

    [Authorize(Roles = "Admin")]
    public class AppUsersController : Controller
    {
        private readonly AppDbContext _context;

        public AppUsersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: AppUsers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Users.ToListAsync());
        }

        // GET: AppUsers/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appUser = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appUser == null)
            {
                return NotFound();
            }

            return View(appUser);
        }



        // GET: AppUsers/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            //admin did not specify a user to edit            
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a supplier to edit!" });
            }

            //find the user in the database
            AppUser appUser = await _context.Users.FindAsync(id);

            //see if the user exists in the database
            if (appUser == null)
            {
                return View("Error", new String[] { "This supplier does not exist in the database!" });
            }

            //send the user to the edit supplier page
            return View(appUser);
        }


        // POST: AppUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("FirstName,LastName, MI, Birthday, PhoneNumber, Street, Zip")] AppUser appUser)
        {

            //if the admin messed up, send them back to the view to try again
            if (ModelState.IsValid == false)
            {
                return View(appUser);
            }

            //if code gets this far, make the updates
            try
            {
                _context.Update(appUser);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "Exception thrown. There was a problem editing this user.", ex.Message });
            }

            //send the user back to the view with all the suppliers
            return RedirectToAction(nameof(Index));
        }

        private bool AppUserExists(string id)
        {
            return _context.Users.Any(a => a.Id == id);
        }

    }
}