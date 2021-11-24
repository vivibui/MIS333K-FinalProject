using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Team_27_FinalProject.Models;
using Team_27_FinalProject.Utilities;
using Team_27_FinalProject.DAL;
using System.Threading.Tasks;
using System.Linq;

namespace Team_27_FinalProject.Seeding
{
    public static class SeedCategories 
    { 
        public static void SeedAllCategories(AppDbContext db)
        {
            if(db.Categories.Count()=5)
            {
                NotSupportedException ex = new NotSupportedException("Category is already updated!");
                throw ex;
            }
            Int32 intCategoriesAdded = 0;
            try
            {
                List<Category> Categories = new List<Category>();

                Category c1 = new Category() { CategoryName = "House" };
                Categories.Add(c1);

                Category c2 = new Category() { CategoryName = "Cabin " };
                Categories.Add(c2);

                Category c3 = new Category() { CategoryName = "Apartment" };
                Categories.Add(c3);

                Category c4 = new Category() { CategoryName = "Condo" };
                Categories.Add(c4);

                Category c5 = new Category() { CategoryName = "Hotel Room" };
                Categories.Add(c5);
        

                //create some counters to help us debug
                //String strCategory = "Begin";

                //adding stuff to the database could cause problems, so we need to
                //wrap this code in a try/catch block

                
               
                foreach (Category categoryToAdd in Categories)
                {

                    //try to see if the Month is in the database
                    Category dbCategory = db.Categories.FirstOrDefault(c => c.CategoryName == categoryToAdd.CategoryName);

                    //if dbMonth is null, that means this record hasn't been added yet
                    if (dbCategory == null)
                    {
                        //Addnto the database
                        db.Categories.Add(categoryToAdd);
                        db.SaveChanges();
                        intCategoriesAdded += 1;
                    }
                }

               
            }
            catch (Exception ex)
            {
                //build a message about what is going on
                String msg = "Categories Added: " + intCategoriesAdded.ToString();
                throw new InvalidOperationException(msg);
            }
        }

    }

}