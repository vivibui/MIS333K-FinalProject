﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Team_27_FinalProject.DAL;
using Team_27_FinalProject.Models;
using Team_27_FinalProject.Utilities;
using Team_27_FinalProject.SendMail;

namespace Team_27_FinalProject.Controllers
{
    //Only logged in users can access
    [Authorize]
    public class AccountController : Controller
    {
        private SignInManager<AppUser> _signInManager;
        private UserManager<AppUser> _userManager;
        private PasswordValidator<AppUser> _passwordValidator;
        private AppDbContext _context;

        public AccountController(AppDbContext appDbContext, UserManager<AppUser> userManager, SignInManager<AppUser> signIn)
        {
            _context = appDbContext;
            _userManager = userManager;
            _signInManager = signIn;
            //user manager only has one password validator
            _passwordValidator = (PasswordValidator<AppUser>)userManager.PasswordValidators.FirstOrDefault();
        }

        // GET: /Account/RegisterCustomer
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }


        //------------------------- REGISTER NEW CUSTOMER ---------------------------
        // GET: /Account/RegisterCustomer
        [AllowAnonymous]
        public IActionResult RegisterCustomer()
        {
            return View();
        }

        // POST: /Account/Register
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> RegisterCustomer(RegisterViewModel rvm)
        {
            //-----------------ADD: AGE VALIDATION-----------------
            //if the date of 18th birthday is more than now, then: 
            if (rvm.Birthday.AddYears(18) > System.DateTime.Now) //not 18
            {
                ModelState.AddModelError("Age Error", "You must be 18 to register.");
                return View(rvm);
            }

            //-----------------ADD: EMAIL DUPLICATION CHECK----------------- 
            //if email is already in database, return error:
            List<AppUser> allUsers = _context.Users.ToList();
            foreach (var u in allUsers)
            {
                if (rvm.Email == u.Email)
                {
                    ModelState.AddModelError("Email Error", "Email exists. Please use another one.");
                    return View(rvm);
                }
            }

            //if registration data is valid, create a new user on the database
            if (ModelState.IsValid == false)
            {
                //this is the sad path - something went wrong, 
                //return the user to the register page to try again
                return View(rvm);
            }
            
            //this code maps the RegisterViewModel to the AppUser domain model
            AppUser newUser = new AppUser
            {
                UserName = rvm.Email,
                Email = rvm.Email,
                PhoneNumber = rvm.PhoneNumber,
                FirstName = rvm.FirstName,
                LastName = rvm.LastName,
                MI = rvm.MI,
                Birthday = rvm.Birthday,
                Street = rvm.Street,
                Zip = rvm.Zip,
        };

            //create AddUserModel
            AddUserModel aum = new AddUserModel()
            {
                User = newUser,
                Password = rvm.Password,

                //TODO: You will need to change this value if you want to 
                //add the user to a different role - just specify the role name.
                RoleName = "Customer"
            };

            //This code uses the AddUser utility to create a new user with the specified password
            IdentityResult result = await Utilities.AddUser.AddUserWithRoleAsync(aum, _userManager, _context);

            if (result.Succeeded) //everything is okay
            { 
                //NOTE: This code logs the user into the account that they just created
                //You may or may not want to log a user in directly after they register - check
                //the business rules!
                Microsoft.AspNetCore.Identity.SignInResult result2 = await _signInManager.PasswordSignInAsync(rvm.Email, rvm.Password, false, lockoutOnFailure: false);

                //Send Email
                String emailSubject = "Welcome to BevoBnB!";
                String emailBody = @"<div> Hi " + newUser.FirstName + ",</div><br/>";
                emailBody = emailBody + @"<div>Thank you for register your account with us.</div><br/>";
                emailBody = emailBody + @"<div> Your Username is:</div>" + newUser.Email;
                emailBody = emailBody + @"<br/><div> Hope you have a wondertime with BevoBnB!</div>";

                EmailMessaging.SendEmail(rvm.Email, emailSubject, emailBody);

                //Send the user to the home page
                return RedirectToAction("Index", "Home");
            }
            else  //the add user operation didn't work, and we need to show an error message
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                //send user back to page with errors
                return View(rvm);
            }
        }


        //------------------------- REGISTER NEW HOST ---------------------------
        // GET: /Account/RegisterHost
        [AllowAnonymous]
        public IActionResult RegisterHost()
        {
            return View();
        }

        // POST: /Account/RegisterHost
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> RegisterHost(RegisterViewModel rvm)
        {
            //-----------------ADD: AGE VALIDATION-----------------
            //if the date of 18th birthday is more than now, then: 
            if (rvm.Birthday.AddYears(18) > System.DateTime.Now) //not 18
            {
                ModelState.AddModelError("Age Error", "You must be 18 to register.");
                return View(rvm);
            }

            //-----------------ADD: EMAIL DUPLICATION CHECK----------------- 
            //if email is already in database, return error:
            List<AppUser> allUsers = _context.Users.ToList();
            foreach (var u in allUsers)
            {
                if (rvm.Email == u.Email)
                {
                    ModelState.AddModelError("Email Error", "Email exists. Please use another one.");
                    return View(rvm);
                }
            }

            //if registration data is valid, create a new user on the database
            if (ModelState.IsValid == false)
            {
                //this is the sad path - something went wrong, 
                //return the user to the register page to try again
                return View(rvm);
            }

            //this code maps the RegisterViewModel to the AppUser domain model
            AppUser newUser = new AppUser
            {
                UserName = rvm.Email,
                Email = rvm.Email,
                PhoneNumber = rvm.PhoneNumber,
                FirstName = rvm.FirstName,
                LastName = rvm.LastName,
                MI = rvm.MI,
                Birthday = rvm.Birthday,
                Street = rvm.Street,
                Zip = rvm.Zip,
            };

            //create AddUserModel
            AddUserModel aum = new AddUserModel()
            {
                User = newUser,
                Password = rvm.Password,

                //TODO: You will need to change this value if you want to 
                //add the user to a different role - just specify the role name.
                RoleName = "Host"
            };

            //This code uses the AddUser utility to create a new user with the specified password
            IdentityResult result = await Utilities.AddUser.AddUserWithRoleAsync(aum, _userManager, _context);

            if (result.Succeeded) //everything is okay
            {
                //NOTE: This code logs the user into the account that they just created
                //You may or may not want to log a user in directly after they register - check
                //the business rules!
                Microsoft.AspNetCore.Identity.SignInResult result2 = await _signInManager.PasswordSignInAsync(rvm.Email, rvm.Password, false, lockoutOnFailure: false);

                //Send Email
                String emailSubject = "Welcome to BevoBnB!";
                String emailBody = @"<div> Hi " + newUser.FirstName + ",</div><br/>";
                emailBody = emailBody + @"<div>Thank you for registering to become a host at Bevo.</div><br/>";
                emailBody = emailBody + @"<div> Your Username is:</div>" + newUser.Email;
                emailBody = emailBody + @"<br/><div> We are looking forward to do business with you.</div>";
                emailBody = emailBody + @"<br/><div> Hope you have a wondertime with BevoBnB!</div>";

                EmailMessaging.SendEmail(rvm.Email, emailSubject, emailBody);

                //Send the user to the home page
                return RedirectToAction("Index", "Home");
            }
            else  //the add user operation didn't work, and we need to show an error message
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                //send user back to page with errors
                return View(rvm);
            }
        }



        //------------------------- LOGIN ---------------------------
        // GET: /Account/Login
        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            if (User.Identity.IsAuthenticated) //user has been redirected here from a page they're not authorized to see
            {
                return View("Error", new string[] { "Access Denied" });
            }
            _signInManager.SignOutAsync(); //this removes any old cookies hanging around
            ViewBag.ReturnUrl = returnUrl; //pass along the page the user should go back to
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel lvm, string returnUrl)
        {
            //if user forgot to include user name or password,
            //send them back to the login page to try again
            if (ModelState.IsValid == false)
            {
                return View(lvm);
            }

            //attempt to sign the user in using the SignInManager
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(lvm.Email, lvm.Password, lvm.RememberMe, lockoutOnFailure: false);

            //if the login worked, take the user to either the url
            //they requested OR the homepage if there isn't a specific url
            if (result.Succeeded)
            {

                //-----------------CHECK IF USER IS ACTIVE----------------- 
                
                //return ?? "/" means if returnUrl is null, substitute "/" (home)
                return Redirect(returnUrl ?? "/");

            }
            else //log in was not successful
            {
                //add an error to the model to show invalid attempt
                ModelState.AddModelError("", "Invalid login attempt.");
                //send user back to login page to try again
                return View(lvm);
            }
        }

        //GET: Account/Index
        public IActionResult Index()
        {
            IndexViewModel ivm = new IndexViewModel();

            //get user info
            String id = User.Identity.Name;
            AppUser user = _context.Users.FirstOrDefault(u => u.UserName == id);

            //populate the view model
            //(i.e. map the domain model to the view model)
            ivm.Email = user.Email;
            ivm.HasPassword = true;
            ivm.UserID = user.Id;
            ivm.UserName = user.UserName;
            ivm.Street = user.Street;
            ivm.Zip = user.Zip;
            ivm.Birthday = user.Birthday;
            ivm.PhoneNumber = user.PhoneNumber;

            //send data to the view
            return View(ivm);
        }



        //Logic for change password
        // GET: /Account/ChangePassword
        public ActionResult ChangePassword()
        {
            return View();
        }

        

        // POST: /Account/ChangePassword
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ChangePassword(ChangePasswordViewModel cpvm)
        {
            //if user forgot a field, send them back to 
            //change password page to try again
            if (ModelState.IsValid == false)
            {
                return View(cpvm);
            }

            //Find the logged in user using the UserManager
            AppUser userLoggedIn = await _userManager.FindByNameAsync(User.Identity.Name);

            //Attempt to change the password using the UserManager
            var result = await _userManager.ChangePasswordAsync(userLoggedIn, cpvm.OldPassword, cpvm.NewPassword);

            //if the attempt to change the password worked
            if (result.Succeeded)
            {
                //sign in the user with the new password
                await _signInManager.SignInAsync(userLoggedIn, isPersistent: false);

                //send the user back to the home page
                return RedirectToAction("Index", "Home");
            }
            else //attempt to change the password didn't work
            {
                //Add all the errors from the result to the model state
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                //send the user back to the change password page to try again
                return View(cpvm);
            }
        }

        //GET:/Account/AccessDenied
        public IActionResult AccessDenied(String ReturnURL)
        {
            return View("Error", new string[] { "Access is denied" });
        }

        // POST: /Account/LogOff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LogOff()
        {
            //sign the user out of the application
            _signInManager.SignOutAsync();

            //send the user back to the home page
            return RedirectToAction("Index", "Home");
        }



        //-------------------ALLOW USER TO CHANGE ADDRESS---------------------

        //Logic for change address
        // GET: /Account/ChangeAddress
        public ActionResult ChangeAddress()
        {
            return View();
        }



        // POST: /Account/ChangeAddress
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ChangeAddress(ChangeAddressViewModel cavm)
        {
            //if user forgot a field, send them back to 
            //change address page to try again
            if (ModelState.IsValid == false)
            {
                return View(cavm);
            }

            try
            {
                //Find the logged in user using the UserManager
                AppUser userLoggedIn = await _userManager.FindByNameAsync(User.Identity.Name);

                //Update the address
                userLoggedIn.Street = cavm.Street;
                userLoggedIn.Zip = cavm.Zip;

                _context.Update(userLoggedIn);
                await _context.SaveChangesAsync();


                //send the user back to the Account/Index to view change 
                return RedirectToAction("Index", "Account");

            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was an error updating this address!", ex.Message });
            }
        }


        //-------------------ALLOW USER TO CHANGE BIRTHDAY ---------------------

        //Logic for change address
        // GET: /Account/ChangeAddress
        public ActionResult ChangeBirthday()
        {
            return View();
        }



        // POST: /Account/ChangeAddress
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ChangeBirthday(ChangeBirthdayViewModel cbvm)
        {
            //if user forgot a field, send them back to 
            //change birthday page to try again
            if (ModelState.IsValid == false)
            {
                return View(cbvm);
            }

            try
            {
                //Find the logged in user using the UserManager
                AppUser userLoggedIn = await _userManager.FindByNameAsync(User.Identity.Name);

                //Update the birthday
                userLoggedIn.Birthday = cbvm.Birthday;

                //-----------------ADD: AGE VALIDATION
                //if the date of 18th birthday is more than now, then: 
                if (cbvm.Birthday.AddYears(18) > System.DateTime.Now) //not 18
                {
                    ModelState.AddModelError("Age Error", "You must be 18 to register");
                    return View(cbvm);
                }

                else
                {
                    _context.Update(userLoggedIn);

                    await _context.SaveChangesAsync();

                    //send the user back to the Account/Index to view change 
                    return RedirectToAction("Index", "Account");
                }
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was an error updating this address!", ex.Message });
            }
        }

        //-------------------ALLOW USER TO CHANGE PHONE ---------------------
        //Logic for change address
        // GET: /Account/ChangeAddress
        public ActionResult ChangePhone()
        {
            return View();
        }



        // POST: /Account/ChangeAddress
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ChangePhone(ChangePhoneViewModel cpvm)
        {
            //if user forgot a field, send them back to 
            //change birthday page to try again
            if (ModelState.IsValid == false)
            {
                return View(cpvm);
            }

            try
            {
                //Find the logged in user using the UserManager
                AppUser userLoggedIn = await _userManager.FindByNameAsync(User.Identity.Name);

                //Update the birthday
                userLoggedIn.PhoneNumber = cpvm.PhoneNumber;

                _context.Update(userLoggedIn);
                await _context.SaveChangesAsync();

                //send the user back to the Account/Index to view change 
                return RedirectToAction("Index", "Account");

            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was an error updating this address!", ex.Message });
            }
        }


        //------------------- CREATE NEW ADMIN ---------------------

        // GET: /Account/RegisterAdmin
        [Authorize(Roles = "Admin")]
        public IActionResult RegisterAdmin()
        {
            return View("RegisterAdmin");
        }

        // POST: /Account/RegisterAdmin
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> RegisterAdmin(RegisterViewModel rvm)
        {
            //-----------------ADD: AGE VALIDATION-----------------
            //if the date of 18th birthday is more than now, then: 
            if (rvm.Birthday.AddYears(18) > System.DateTime.Now) //not 18
            {
                ModelState.AddModelError("Age Error", "You must be 18 to register.");
                return View(rvm);
            }

            //-----------------ADD: EMAIL DUPLICATION CHECK----------------- 
            //if email is already in database, return error:
            List<AppUser> allUsers = _context.Users.ToList();
            foreach (var u in allUsers)
            {
                if (rvm.Email == u.Email)
                {
                    ModelState.AddModelError("Email Error", "Email exists. Please use another one.");
                    return View(rvm);
                }
            }

            //if registration data is valid, create a new user on the database
            if (ModelState.IsValid == false)
            {
                //this is the sad path - something went wrong, 
                //return the user to the register page to try again
                return View(rvm);
            }

            //this code maps the RegisterViewModel to the AppUser domain model
            AppUser newUser = new AppUser
            {
                UserName = rvm.Email,
                Email = rvm.Email,
                PhoneNumber = rvm.PhoneNumber,
                FirstName = rvm.FirstName,
                LastName = rvm.LastName,
                MI = rvm.MI,
                Birthday = rvm.Birthday,
                Street = rvm.Street,
                Zip = rvm.Zip,
            };

            //create AddUserModel
            AddUserModel aum = new AddUserModel()
            {
                User = newUser,
                Password = rvm.Password,

                //TODO: You will need to change this value if you want to 
                //add the user to a different role - just specify the role name.
                RoleName = "Admin"
            };

            //This code uses the AddUser utility to create a new user with the specified password
            IdentityResult result = await Utilities.AddUser.AddUserWithRoleAsync(aum, _userManager, _context);

            if (result.Succeeded) //everything is okay
            {

                //Send the user to the Manage Users page
                return RedirectToAction("Index", "RoleAdmin");
            }
            else  //the add user operation didn't work, and we need to show an error message
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                //send user back to page with errors
                return View(rvm);
            }
        }

    }
}