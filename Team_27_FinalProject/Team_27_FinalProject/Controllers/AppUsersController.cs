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
        private UserManager<AppUser> _userManager;
        private PasswordValidator<AppUser> _passwordValidator;

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

        //-------------------------------------------- EDIT --------------------------------------------

        // GET: AppUsers/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            //admin did not specify a user to edit            
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a user to edit!" });
            }

            //find the user in the database
            AppUser appUser = await _context.Users.FindAsync(id);

            //see if the user exists in the database
            if (appUser == null)
            {
                return View("Error", new String[] { "This user does not exist in the database!" });
            }

            //send the user to the edit user page
            return View(appUser);
        }


        // POST: AppUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("FirstName,LastName, MI, Birthday, PhoneNumber, Street, Zip")] EditUserViewModel euvm)
        {
            AppUser appUser = await _context.Users.FindAsync(id);

            if (!ModelState.IsValid)
            {
                return View(appUser);
            }

            // Update it with the values from the view model
            appUser.FirstName = euvm.FirstName;
            appUser.LastName = euvm.LastName;
            appUser.MI = euvm.MI;
            appUser.Birthday = euvm.Birthday;
            appUser.PhoneNumber = euvm.PhoneNumber;
            appUser.Street = euvm.Street; 
            appUser.Zip = euvm.Zip;


            //-----------------ADD: AGE VALIDATION-----------------
            //if the date of 18th birthday is more than now, then: 
            if (appUser.Birthday.AddYears(18) > System.DateTime.Now) //not 18
            {
                ModelState.AddModelError("Age Error", "You must be 18 to register.");
                return View(appUser);
            }

            // Apply the changes if any to the db
            _context.Update(appUser);
            await _context.SaveChangesAsync();

            //Return
            return RedirectToAction("Index", "AppUsers");
        }


        //-------------------------------------------- CHANGE PASSWORD --------------------------------------------

        //Logic for change password
        // GET: /Account/ChangePassword
        public async Task<IActionResult> ChangePasswordAdmin(string id)
        {
            //admin did not specify a user to edit            
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a user to edit!" });
            }

            //find the user in the database
            AppUser appUser = await _context.Users.FindAsync(id);

            //see if the user exists in the database
            if (appUser == null)
            {
                return View("Error", new String[] { "This user does not exist in the database!" });
            }

            var model = new ChangePasswordAdminViewModel
            {
                Id = appUser.Id
            };

            return View(model);
        }


        // POST: /Account/ChangePassword
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ChangePasswordAdmin(ChangePasswordAdminViewModel cpavm)
        {
            AppUser appUser = _context.Users.FirstOrDefault(u => u.Id == cpavm.Id);

            if (appUser == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {cpavm.Id} cannot be found";
                return View("Error", new String[]{"User is not found."});
            }

            try
            {
                appUser = _context.Users.FirstOrDefault(u => u.Id == cpavm.Id);

                //Attempt to change the password using the UserManager
                var token = await _userManager.GeneratePasswordResetTokenAsync(appUser);

                var result = await _userManager.ResetPasswordAsync(appUser, token, cpavm.ConfirmPassword);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "AppUsers");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was a problem update this password.", ex.Message });
            }

            //send the user back to the view with all the suppliers
            return RedirectToAction(nameof(Index));
        }

    }
}