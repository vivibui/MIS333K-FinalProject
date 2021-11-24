using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Team_27_FinalProject.Models;
using Team_27_FinalProject.Utilities;
using Team_27_FinalProject.DAL;
using System.Threading.Tasks;

namespace Team_27_FinalProject.Seeding
{
    public static class SeedReviews
    {
        public static void SeedReviews(AppDbContext db)
        {
            //Create a counter and a flag so we will know which record is causing problems
            intReviewID = reviewToAdd.ReviewID;
            Reviews dbReview = db.Reviews.FirstOrDefault(b => b.ReviewID == reviewToAdd.ReviewID);

            List<Review> Reviews = new List<Review>();
            Review r1 = new Review()
            {
                Address = "588 Alan Rest, Port Stephanieville, MS 63590",
                Customer = "father.Ingram@aool.com",
                Rating = 4,
                Content = " "
            };
            Reviews.Add(r1);

            try  //attempt to add or update the book
            {
                //loop through each of the books in the list
                foreach (Review ReviewToAdd in Reviews)
                {
                    //set the flag to help with debugging
                    strReviewAddress = reviewToAdd.Address;

                    //look to see if the book is in the database - this assumes that no
                    //two books have the same title
                    Review dbReview = db.Reviews.FirstOrDefault(p => p.Address == reviewToAdd.Address);

                    //if the dbBook is null, this title is not in the database
                    if (dbReview == null)
                    {
                        //add the book to the database and save changes
                        db.Reviews.Add(ReviewToAdd);
                        db.SaveChanges();
                        //update the counter to help with debugging
                        intReviewsAdded += 1;
                    }
                    else //dbBook is not null - this title *is* in the database
                    {
                        //update all of the book's properties
                        dbReview.Address = ReviewToAdd.Address;
                        dbReview.Customer = ReviewToAdd.Customer;
                        dbReview.Rating = ReviewToAdd.Rating;
                        dbReview.Content = ReviewToAdd.Content;


                        //since we found the correct genre object in a previous step,
                        //this update is easy - both dbBook and bookToAdd have a Genre 
                        //object for this property
                        //dbBook.Genre = bookToAdd.Genre;

                        //update the database and save the changes
                        db.Update(dbReview);
                        db.SaveChanges();

                        //update the counter to help with debugging
                        intReviewsAdded += 1;
                    } //this is the end of the else
                } //this is the end of the foreach loop for the books
            }//this is the end of the try block

            catch (Exception ex)//something went wrong with adding or updating
            {
                //Build a messsage using the flags we created
                String msg = "  Repositories added:" + intReviewsAdded + "; Error on " + strReviewStreet;

                //throw the exception with the new message
                throw new InvalidOperationException(ex.Message + msg);
            }
        }

    }

}