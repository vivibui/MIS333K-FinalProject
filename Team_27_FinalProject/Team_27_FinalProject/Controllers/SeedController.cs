using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Team_27_FinalProject.Models;
using Team_27_FinalProject.DAL;
using Microsoft.AspNetCore.Authorization;

namespace Team_27_FinalProject.Controllers
{
    //Only Admin can access
    [Authorize(Roles = "Admin")]

    public class SeedController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public SeedController(AppDbContext db, UserManager<AppUser> um, RoleManager<IdentityRole> rm)
        {
            _context = db;
            _userManager = um;
            _roleManager = rm;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> SeedRoles()
        {
            try
            {
                await Seeding.SeedRoles.AddAllRoles(_roleManager);
            }
            catch (Exception ex)
            {
                //add the error messages to a list of strings
                List<String> errorList = new List<String>();

                //Add the outer message
                errorList.Add(ex.Message);

                //Add the message from the inner exception
                errorList.Add(ex.InnerException.Message);

                //Add additional inner exception messages, if there are any
                if (ex.InnerException.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                return View("Error", errorList);
            }

            //this is the happy path - seeding worked!
            return View("Confirm");
        }

        public IActionResult SeedAllCategories()
        {
            try
            {
                //call the SeedAllGenres method from your Seeding folder
                //you will need to pass in the instance of AppDbContext
                //that you set in the constructor
                Seeding.SeedCategories.SeedAllCategories(_context);
            }
            catch (Exception ex)
            {
                //add the error messages to a list of strings
                List<String> errorList = new List<String>();

                errorList.Add("There was a problem adding this category");

                //Add the outer message
                errorList.Add(ex.Message);

                //Add the message from the inner exception, if there is one
                if (ex.InnerException != null)
                {
                    errorList.Add(ex.InnerException.Message);

                    //Add additional inner exception messages, if there are any
                    if (ex.InnerException.InnerException != null)
                    {
                        errorList.Add(ex.InnerException.InnerException.Message);
                    }
                }
                //return the user to the error view
                return View("Error", errorList);
            }

            //everything is okay - send user to confirmation page
            return View("Confirm");
        }

        public IActionResult SeedAllReviews()
        {
            try
            {
                //call the SeedAllGenres method from your Seeding folder
                //you will need to pass in the instance of AppDbContext
                //that you set in the constructor
                Seeding.SeedReviews.SeedAllReviews(_context);
            }
            catch (Exception ex)
            {
                //add the error messages to a list of strings
                List<String> errorList = new List<String>();

                errorList.Add("There was a problem adding this review");

                //Add the outer message
                errorList.Add(ex.Message);

                //Add the message from the inner exception, if there is one
                if (ex.InnerException != null)
                {
                    errorList.Add(ex.InnerException.Message);

                    //Add additional inner exception messages, if there are any
                    if (ex.InnerException.InnerException != null)
                    {
                        errorList.Add(ex.InnerException.InnerException.Message);
                    }
                }
                //return the user to the error view
                return View("Error", errorList);
            }

            //everything is okay - send user to confirmation page
            return View("Confirm");
        }

        public IActionResult SeedAllProperties()
        {
            try
            {
                //call the SeedAllGenres method from your Seeding folder
                //you will need to pass in the instance of AppDbContext
                //that you set in the constructor
                Seeding.SeedProperties.SeedAllProperties(_context);
            }
            catch (Exception ex)
            {
                //add the error messages to a list of strings
                List<String> errorList = new List<String>();

                errorList.Add("There was a problem adding this property");

                //Add the outer message
                errorList.Add(ex.Message);

                //Add the message from the inner exception, if there is one
                if (ex.InnerException != null)
                {
                    errorList.Add(ex.InnerException.Message);

                    //Add additional inner exception messages, if there are any
                    if (ex.InnerException.InnerException != null)
                    {
                        errorList.Add(ex.InnerException.InnerException.Message);
                    }
                }
                //return the user to the error view
                return View("Error", errorList);
            }

            //everything is okay - send user to confirmation page
            return View("Confirm");
        }


        public async Task<IActionResult> SeedPeople()
        {
            try
            {
                await Seeding.SeedUsers.SeedAllUsers(_userManager, _context);
            }
            catch (Exception ex)
            {
                //add the error messages to a list of strings
                List<String> errorList = new List<String>();

                //Add the outer message
                errorList.Add(ex.Message);

                //Add the message from the inner exception
                errorList.Add(ex.InnerException.Message);

                //Add additional inner exception messages, if there are any
                if (ex.InnerException.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                return View("Error", errorList);
            }

            //this is the happy path - seeding worked!
            return View("Confirm");
        }


    }
}
