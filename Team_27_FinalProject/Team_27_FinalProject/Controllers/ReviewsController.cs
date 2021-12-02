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



        //-------------------------------------------------------Customer index for review view-------------------------------------------------------------





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


        //-------------------------------------------------------Customer create for creating review-------------------------------------------------------------

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

            //List<Review> myReviews = _context.Reviews.ToList();
            //foreach (var u in myReviews)
            //{
            //    if (create.ReviewID == u.ReviewID)
            //    {
            //        ModelState.AddModelError("Email Error", "Email exists. Please use another one.");
            //        return View(rvm);
            //    }
            //}
            // Property dbProperty = _context.Properties.Find(ReviewID);

            await _context.SaveChangesAsync();

            ViewBag.ConfirmCreateR = review;

            return View("Create");
        }

        //-------------------------------------------------------Customer edit for editiing review-------------------------------------------------------------

        public IActionResult AdminDispute()
        {
            return View();


        }

        // POST: Reviews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AdminDispute([Bind("ReviewID,Rating,Content")] Review review)
        {
            if (ModelState.IsValid == false)
            {
                return View(review);
            }

            await _context.SaveChangesAsync();

            ViewBag.ConfirmCreate = review;

            return View("Create");
        }

        //-------------------------------------------------------Customer edit for editiing review-------------------------------------------------------------

        [Authorize(Roles = "Customer")]
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
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(review);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReviewExists(review.ReviewID))
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
            return View(review);
        }


        // GET: Reviews/Delete/5
        public async Task<IActionResult> Delete(int? id)
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

        // POST: Reviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var review = await _context.Reviews.FindAsync(id);
            _context.Reviews.Remove(review);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReviewExists(int id)
        {
            return _context.Reviews.Any(e => e.ReviewID == id);
        }
    }
}
