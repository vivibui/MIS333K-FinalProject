using Team_27_FinalProject.Models;
using Team_27_FinalProject.DAL;
using System.Collections.Generic;
using System;
using System.Linq;


namespace Team_27_FinalProject.Seeding
{
	public static class SeedReviews
	{
		public static void SeedAllReviews(AppDbContext db)
		{
			if (db.Reviews.Count() == 21)
			{
				throw new NotSupportedException("The database already contains all 21 reviews!");
			}

			Int32 intReviewsAdded = 0;
			String strReviewStreet = "Begin"; //helps to keep track of error on books
			List<Review> Reviews = new List<Review>();

			try
			{
				Review r1 = new Review()
				{
					Rating = 4,
					Content = " "
				};
				r1.Property = db.Properties.FirstOrDefault(g => g.Street == "588 Alan Rest");
				//r1.Property = db.Properties.FirstOrDefault(g => g.City == " Port Stephanieville");
				//r1.Property = db.Properties.FirstOrDefault(g => g.State == "MS");
				//r1.Property = db.Properties.FirstOrDefault(g => g.Zip == "63590");
				r1.AppUser = db.Users.FirstOrDefault(g => g.Email == "father.Ingram@aool.com");
				Reviews.Add(r1);

				Review r2 = new Review()
				{
					Rating = 3,
					Content = "It was meh, ya know? It was really close to the coast, but the beaches were kinda trashed. The apartment was nice, but there wasn't an elevator."
				};
				r2.Property = db.Properties.FirstOrDefault(g => g.Street == "1168 Gary Fords Apt. 308");
				//r2.Property = db.Properties.FirstOrDefault(g => g.City == " Port Trevor");
				//r2.Property = db.Properties.FirstOrDefault(g => g.State == "RI");
				//r2.Property = db.Properties.FirstOrDefault(g => g.Zip == "96954");
				r2.AppUser = db.Users.FirstOrDefault(g => g.Email == "orielly@foxnets.com");
				Reviews.Add(r2);

				Review r3 = new Review()
				{
					Rating = 4,
					Content = ""
				};
				r3.Property = db.Properties.FirstOrDefault(g => g.Street == "03541 Ryan Islands Apt. 562");
				//r3.Property = db.Properties.FirstOrDefault(g => g.City == " East Michaelfort");
				//r3.Property = db.Properties.FirstOrDefault(g => g.State == "HI");
				//r3.Property = db.Properties.FirstOrDefault(g => g.Zip == "90576");
				r3.AppUser = db.Users.FirstOrDefault(g => g.Email == "father.Ingram@aool.com");
				Reviews.Add(r3);

				Review r4 = new Review()
				{
					Rating = 2,
					Content = " "
				};
				r4.Property = db.Properties.FirstOrDefault(g => g.Street == "588 Alan Rest");
				//r4.Property = db.Properties.FirstOrDefault(g => g.City == " Port Stephanieville");
				//r4.Property = db.Properties.FirstOrDefault(g => g.State == "MS");
				//r4.Property = db.Properties.FirstOrDefault(g => g.Zip == "63590");
				r4.AppUser = db.Users.FirstOrDefault(g => g.Email == "tuck33@puppy.com");
				Reviews.Add(r4);

				Review r5 = new Review()
				{
					Rating = 3,
					Content = "Nebraska was... interesting"
				};
				r5.Property = db.Properties.FirstOrDefault(g => g.Street == "94102 Sims Port Suite 187");
				//r5.Property = db.Properties.FirstOrDefault(g => g.City == " Florestown");
				//r5.Property = db.Properties.FirstOrDefault(g => g.State == "NE");
				//r5.Property = db.Properties.FirstOrDefault(g => g.Zip == "80082");
				r5.AppUser = db.Users.FirstOrDefault(g => g.Email == "father.Ingram@aool.com");
				Reviews.Add(r5);

				Review r6 = new Review()
				{
					Rating = 1,
					Content = "There was corn EVERYWHERE! I looked left and BAM, CORN. Looked right, BAM, CORN"
				};
				r6.Property = db.Properties.FirstOrDefault(g => g.Street == "94102 Sims Port Suite 187");
				//r6.Property = db.Properties.FirstOrDefault(g => g.City == " Florestown");
				//r6.Property = db.Properties.FirstOrDefault(g => g.State == "NE");
				//r6.Property = db.Properties.FirstOrDefault(g => g.Zip == "80082");
				r6.AppUser = db.Users.FirstOrDefault(g => g.Email == "tfreeley@puppy.com");
				Reviews.Add(r6);

				Review r7 = new Review()
				{
					Rating = 1,
					Content = "Worst. Stay. Ever. Never using BevoBnB again"
				};
				r7.Property = db.Properties.FirstOrDefault(g => g.Street == "94102 Sims Port Suite 187");
				//r7.Property = db.Properties.FirstOrDefault(g => g.City == " Florestown");
				//r7.Property = db.Properties.FirstOrDefault(g => g.State == "NE");
				//r7.Property = db.Properties.FirstOrDefault(g => g.Zip == "80082");
				r7.AppUser = db.Users.FirstOrDefault(g => g.Email == "ra@aoo.com");
				Reviews.Add(r7);

				Review r8 = new Review()
				{
					Rating = 5,
					Content = " "
				};
				r8.Property = db.Properties.FirstOrDefault(g => g.Street == "693 Michael Estate");
				//r8.Property = db.Properties.FirstOrDefault(g => g.City == " Lake Michael");
				//r8.Property = db.Properties.FirstOrDefault(g => g.State == "NM");
				//r8.Property = db.Properties.FirstOrDefault(g => g.Zip == "3009");
				r8.AppUser = db.Users.FirstOrDefault(g => g.Email == "orielly@foxnets.com");
				Reviews.Add(r8);

				Review r9 = new Review()
				{
					Rating = 2,
					Content = " "
				};
				r9.Property = db.Properties.FirstOrDefault(g => g.Street == "457 Vargas Island Suite 853");
				//r9.Property = db.Properties.FirstOrDefault(g => g.City == " Lake Patrickstad");
				//r9.Property = db.Properties.FirstOrDefault(g => g.State == "WY");
				//r9.Property = db.Properties.FirstOrDefault(g => g.Zip == "67652");
				r9.AppUser = db.Users.FirstOrDefault(g => g.Email == "orielly@foxnets.com");
				Reviews.Add(r9);

				Review r10 = new Review()
				{
					Rating = 1,
					Content = "It was SO hard to book this place. Who coded this site anyway? ;)"
				};
				r10.Property = db.Properties.FirstOrDefault(g => g.Street == "693 Michael Estate");
				//r10.Property = db.Properties.FirstOrDefault(g => g.City == " Lake Michael");
				//r10.Property = db.Properties.FirstOrDefault(g => g.State == "NM");
				//r10.Property = db.Properties.FirstOrDefault(g => g.Zip == "3009");
				r10.AppUser = db.Users.FirstOrDefault(g => g.Email == "tfreeley@puppy.com");
				Reviews.Add(r10);

				Review r11 = new Review()
				{
					Rating = 4,
					Content = " "
				};
				r11.Property = db.Properties.FirstOrDefault(g => g.Street == "71664 Kim Throughway");
				//r11.Property = db.Properties.FirstOrDefault(g => g.City == " Chelsealand");
				//r11.Property = db.Properties.FirstOrDefault(g => g.State == "AK");
				//r11.Property = db.Properties.FirstOrDefault(g => g.Zip == "65056");
				r11.AppUser = db.Users.FirstOrDefault(g => g.Email == "tuck33@puppy.com");
				Reviews.Add(r11);

				Review r12 = new Review()
				{
					Rating = 5,
					Content = "This place rocked!"
				};
				r12.Property = db.Properties.FirstOrDefault(g => g.Street == "693 Michael Estate");
				//r12.Property = db.Properties.FirstOrDefault(g => g.City == " Lake Michael");
				//r12.Property = db.Properties.FirstOrDefault(g => g.State == "NM");
				//r12.Property = db.Properties.FirstOrDefault(g => g.Zip == "3009");
				r12.AppUser = db.Users.FirstOrDefault(g => g.Email == "ra@aoo.com");
				Reviews.Add(r12);

				Review r13 = new Review()
				{
					Rating = 4,
					Content = " "
				};
				r13.Property = db.Properties.FirstOrDefault(g => g.Street == "693 Michael Estate");
				//r13.Property = db.Properties.FirstOrDefault(g => g.City == " Lake Michael");
				//r13.Property = db.Properties.FirstOrDefault(g => g.State == "NM");
				//r13.Property = db.Properties.FirstOrDefault(g => g.Zip == "3009");
				r13.AppUser = db.Users.FirstOrDefault(g => g.Email == "fd@puppy.com");
				Reviews.Add(r13);

				Review r14 = new Review()
				{
					Rating = 4,
					Content = " "
				};
				r14.Property = db.Properties.FirstOrDefault(g => g.Street == "457 Vargas Island Suite 853");
				//r14.Property = db.Properties.FirstOrDefault(g => g.City == " Lake Patrickstad");
				//r14.Property = db.Properties.FirstOrDefault(g => g.State == "WY");
				//r14.Property = db.Properties.FirstOrDefault(g => g.Zip == "67652");
				r14.AppUser = db.Users.FirstOrDefault(g => g.Email == "lamemartin.Martin@aool.com");
				Reviews.Add(r14);

				Review r15 = new Review()
				{
					Rating = 1,
					Content = "There were 1...5...22 roaches? I lost count."
				};
				r15.Property = db.Properties.FirstOrDefault(g => g.Street == "94102 Sims Port Suite 187");
				//r15.Property = db.Properties.FirstOrDefault(g => g.City == " Florestown");
				//r15.Property = db.Properties.FirstOrDefault(g => g.State == "NE");
				//r15.Property = db.Properties.FirstOrDefault(g => g.Zip == "80082");
				r15.AppUser = db.Users.FirstOrDefault(g => g.Email == "fd@puppy.com");
				Reviews.Add(r15);

				Review r16 = new Review()
				{
					Rating = 1,
					Content = " "
				};
				r16.Property = db.Properties.FirstOrDefault(g => g.Street == "1168 Gary Fords Apt. 308");
				//r16.Property = db.Properties.FirstOrDefault(g => g.City == " Port Trevor");
				//r16.Property = db.Properties.FirstOrDefault(g => g.State == "RI");
				//r16.Property = db.Properties.FirstOrDefault(g => g.Zip == "96954");
				r16.AppUser = db.Users.FirstOrDefault(g => g.Email == "sheff44@puppy.com");
				Reviews.Add(r16);

				Review r17 = new Review()
				{
					Rating = 4,
					Content = "I LOVED the place! Had a nice view of the mountains"
				};
				r17.Property = db.Properties.FirstOrDefault(g => g.Street == "1220 Heidi Rue Apt. 998");
				//r17.Property = db.Properties.FirstOrDefault(g => g.City == " West Haleyburgh");
				//r17.Property = db.Properties.FirstOrDefault(g => g.State == "CO");
				//r17.Property = db.Properties.FirstOrDefault(g => g.Zip == "5222");
				r17.AppUser = db.Users.FirstOrDefault(g => g.Email == "fd@puppy.com");
				Reviews.Add(r17);

				Review r18 = new Review()
				{
					Rating = 5,
					Content = " "
				};
				r18.Property = db.Properties.FirstOrDefault(g => g.Street == "1220 Heidi Rue Apt. 998");
				//r18.Property = db.Properties.FirstOrDefault(g => g.City == " West Haleyburgh");
				//r18.Property = db.Properties.FirstOrDefault(g => g.State == "CO");
				//r18.Property = db.Properties.FirstOrDefault(g => g.Zip == "5222");
				r18.AppUser = db.Users.FirstOrDefault(g => g.Email == "tuck33@puppy.com");
				Reviews.Add(r18);

				Review r19 = new Review()
				{
					Rating = 5,
					Content = "My stay was amazing! Saved my marriage"
				};
				r19.Property = db.Properties.FirstOrDefault(g => g.Street == "588 Alan Rest");
				//r19.Property = db.Properties.FirstOrDefault(g => g.City == " Port Stephanieville");
				//r19.Property = db.Properties.FirstOrDefault(g => g.State == "MS");
				//r19.Property = db.Properties.FirstOrDefault(g => g.Zip == "63590");
				r19.AppUser = db.Users.FirstOrDefault(g => g.Email == "orielly@foxnets.com");
				Reviews.Add(r19);

				Review r20 = new Review()
				{
					Rating = 2,
					Content = " "
				};
				r20.Property = db.Properties.FirstOrDefault(g => g.Street == "457 Vargas Island Suite 853");
				//r20.Property = db.Properties.FirstOrDefault(g => g.City == " Lake Patrickstad");
				//r20.Property = db.Properties.FirstOrDefault(g => g.State == "WY");
				//r20.Property = db.Properties.FirstOrDefault(g => g.Zip == "67652");
				r20.AppUser = db.Users.FirstOrDefault(g => g.Email == "sheff44@puppy.com");
				Reviews.Add(r20);

				Review r21 = new Review()
				{
					Rating = 2,
					Content = "My wife's attitude was the only thing rougher than the sand at the nearby beaches"
				};
				r21.Property = db.Properties.FirstOrDefault(g => g.Street == "03541 Ryan Islands Apt. 562");
				//r21.Property = db.Properties.FirstOrDefault(g => g.City == " East Michaelfort");
				//r21.Property = db.Properties.FirstOrDefault(g => g.State == "HI");
				//r21.Property = db.Properties.FirstOrDefault(g => g.Zip == "90576");
				r21.AppUser = db.Users.FirstOrDefault(g => g.Email == "orielly@foxnets.com");
				Reviews.Add(r21);


				try
				{
					foreach (Review reviewToAdd in Reviews)
					{
                        int intReviewID = reviewToAdd.ReviewID;
                        Review dbReview = db.Reviews.FirstOrDefault(b => b.ReviewID == reviewToAdd.ReviewID);
						if (dbReview == null) //this title doesn't exist
						{
							db.Reviews.Add(reviewToAdd);
							db.SaveChanges();
							intReviewsAdded += 1;
						}
						else //property exists - update values
						{

							dbReview.Rating = reviewToAdd.Rating;
							dbReview.Content = reviewToAdd.Content;
							db.Update(dbReview);
							db.SaveChanges();
							intReviewsAdded += 1;
						}
					}
				}
				catch (Exception ex)
				{
					String msg = "  Repositories added:" + intReviewsAdded + "; Error on " + strReviewStreet;
					throw new InvalidOperationException(ex.Message + msg);
				}
			}
			catch (Exception e)
			{
				throw new InvalidOperationException(e.Message);
			}
		}
	}
}
