using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Team_27_FinalProject.DAL;
using Team_27_FinalProject.Models;

namespace Team_27_FinalProject.Controllers
{

    public class ReviewsController : Controller
    {
        private UserManager<AppUser> _userManager;

        private AppDbContext _context;

        public ReviewsController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Reviews
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Reviews.ToListAsync());
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        //-------------------------------------------------------Customer index for review view-------------------------------------------------------------
        // GET: Reviews
        //Only Customer can access
        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> CustomerIndex()
        {

            
            //Find the logged in user using the UserManager
            var userLoggedIn = await _userManager.FindByNameAsync(User.Identity.Name);

            var query = from r in _context.Reviews
                        select r;

            query = query.Where(r => r.AppUser.Email == userLoggedIn.Email);

            //.ToList() method to execute the query. Include statement to get the navigational data
            List<Review> AllYourReviews = query.Include(r => r.Property)
                                                    .Include(r => r.AppUser)
                                                    .ToList();

            return View(AllYourReviews);

        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        //-------------------------------------------------------HOST index for review view-------------------------------------------------------------
        // GET: Reviews
        //Only Customer can access
        [Authorize(Roles = "Host")]
        public async Task<IActionResult> HostIndex()
        {


            //Find the logged in user using the UserManager
            var userLoggedIn = await _userManager.FindByNameAsync(User.Identity.Name);

            var query = from r in _context.Reviews
                        select r;

            query = query.Where(r => r.Property.AppUser.UserName == User.Identity.Name);

            //.ToList() method to execute the query. Include statement to get the navigational data
            List<Review> HostIndex = query.Include(r => r.Property)
                                                    .Include(r => r.AppUser)
                                                    //.Where(r => r.Property.AppUser.UserName == User.Identity.Name)
                                                    .ToList();

            return View(HostIndex);

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////






        // GET: Reviews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Reviews
                .FirstOrDefaultAsync(m => m.ReviewID == id);
            if (review == null)
            {
                return NotFound();
            }

            return View(review);
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        //-------------------------------------------------------Customer CREATE for creating review-------------------------------------------------------------

        [Authorize(Roles = "Customer")]
        // GET: Reviews/Create
        public IActionResult Create()
        {
            return View();

            
        }

        // POST: Reviews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReviewID,Rating,Content")] Review review)
        {

            review.AppUser = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);



            if (ModelState.IsValid == false)
            {
                return View(review);
            }


            await _context.SaveChangesAsync();

            ViewBag.ConfirmCreateR = review;

            return View("Create");
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        //-------------------------------------------------------HOST EDIT for disputing review-------------------------------------------------------------

        [Authorize(Roles = "Host")]
        // GET: Reviews/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Reviews.FindAsync(id);
            if (review == null)
            {
                return NotFound();
            }
            return View(review);
        }


        // POST: Reviews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReviewID,Rating,Content,Disputed,DisputeReason")] Review review)
        {
            
            if (id != review.ReviewID)
            {
                return View("Error", new String[] { "There was a problem editing this record. Try again!" });
            }

            //if code gets this far, update the record
            try
            {
                //create a new review
                Review dbR;

                //find the existing review in the database
                dbR = _context.Reviews
                      .Include(p => p.Property)
                      .Include(p => p.AppUser)
                      .FirstOrDefault(p => p.ReviewID == review.ReviewID);

                //Set 
                dbR.DisputeReason = review.DisputeReason;
                dbR.IsDisputed = true;
                dbR.DStatus = Review.DisputeStatus.Pending;

                //save changes
                _context.Update(dbR);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was a problem editing this record", ex.Message });
            }

            return View("ConfirmDispute");
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //-------------------------------------------------------CUSTOMER EDIT for editiing review-------------------------------------------------------------


        [Authorize(Roles = "Customer")]
        // GET: Reviews/Edit/5
        public async Task<IActionResult> CEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Reviews.FindAsync(id);
            if (review == null)
            {
                return NotFound();
            }
            return View(review);
        }


        // POST: Reviews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CEdit(int id, [Bind("ReviewID,Rating,Content,Disputed,DisputeReason")] Review review)
        {

            //this is a security measure to make sure the user is editing the correct order
            if (id != review.ReviewID)
            {
                return View("Error", new String[] { "There was a problem editing this order. Try again!" });
            }

            //if there is something wrong with this order, try again
            if (ModelState.IsValid == false)
            {
                return View(review);
            }

            //if code gets this far, update the record
            try
            {
                //find the record in the database
                Review dbReview = _context.Reviews.Find(review.ReviewID);

                _context.Update(dbReview);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was an error updating thisreview!", ex.Message });
            }

            //send the user to the Index page.
            return RedirectToAction(nameof(CustomerIndex));




        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //-------------------------------------------------------ADMIN edit for disputing reviews ------------------------------------------------------------

        // GET: Properties/Edit/5
        // GET: Properties for admin to approve or reject newly created properties 
        [Authorize(Roles = "Admin")]
        public IActionResult PendingCreateAdminDisputeIndex()
        {
            var query = from r in _context.Reviews
                        select r;

            query = query.Where(p => p.DStatus == Review.DisputeStatus.Pending);

            //.ToList() method to execute the query. Include statement to get the navigational data
            List<Review> PendingReviews = query.Include(p => p.Property)
                                                    .Where(r => r.DStatus == Review.DisputeStatus.Pending)
                                                    .Include(p => p.AppUser)
                                                    .ToList();

            return View(PendingReviews);
        }

        [Authorize(Roles = "Admin")]
        // GET DETAILS
        [HttpGet]
        public IActionResult PendingCreateAdminDisputeView(int? id)
        {
            //if the user didn't specify an id, we can't show them 
            //the data, so show an error instead
            if (id == null)
            {
                return View("Error", new string[] { "Please specify a property to edit!" });
            }

            //find the property in the database
            //be sure to change the data type to property instead of 'var'
            Review review = _context.Reviews.Include(r => r.Property)
            .FirstOrDefault(r => r.ReviewID == id);

            //if the property does not exist in the database, then show the user
            //an error message
            if (review == null)
            {
                return View("Error", new string[] { "This property was not found!" });
            }

            return View(review);

        }

        // POST DETAILS
        [HttpPost]
        public async Task<IActionResult> PendingCreateAdminDisputeView(int id, string button, Review review)
        {
            //this is a security check to make sure they are editing the correct record
            if (id != review.ReviewID)
            {
                return View("Error", new String[] { "There was a problem editing this record. Try again!" });
            }

            //information is not valid, try again
            if (ModelState.IsValid == false)
            {
                return View(review);
            }

            //create a new review
            Review dbR;
            //if code gets this far, update the record
            try
            {
                //find the existing property in the database
                //include all nav. properties
                dbR = _context.Reviews
                      //.Where(r => r.DStatus == Review.DisputeStatus.Pending)
                      .Include(r => r.Property)
                      .Include(r => r.AppUser)
                      .FirstOrDefault(r => r.ReviewID == review.ReviewID);

                //agress with host and it should be removed from site
                if (button.ToLower() == "approve")
                {
                    dbR.DStatus = review.DStatus = Review.DisputeStatus.Accepted;
                    _context.Reviews.Remove(dbR);
                    await _context.SaveChangesAsync();
               
                }
                //agress with customer review and it should stay on site
                else if (button.ToLower() == "reject")
                {
                    dbR.DStatus = review.DStatus = Review.DisputeStatus.Rejected;
                    dbR.IsDisputed = false;
                    //dbR.DisputeReason = "";

                }

                //save changes
                _context.Update(dbR);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was a problem editing this record", ex.Message });
            }

            //if code gets this far, go back to view list of all active properties 
            return RedirectToAction("PendingCreateAdminDisputeIndex");
        }










        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // GET: Reviews/Delete/5
       
    }
}
