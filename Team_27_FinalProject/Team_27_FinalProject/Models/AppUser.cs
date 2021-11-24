using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Team_27_FinalProject.Models
{
    public class AppUser:IdentityUser
    {
        //IsActive (Y/N)
        [Display(Name = "Is Active? (Y/N)")]
        public Boolean IsActive { get; set; }

        //First Name
        [Display(Name = "First Name:")]
        public String FirstName { get; set; }

        //Middle Name
        [Display(Name = "Middle Initial:")]
        public String MI { get; set; }

        //Last Name
        [Display(Name = "Last Name:")]
        public String LastName { get; set; }

        //Birthday
        [Display(Name = "Birthday:")]
        public DateTime Birthday { get; set; }

        //Address
        [Display(Name = "Address:")]
        public String Address { get; set; }

        //Zipcode
        [Display(Name = "Zipcode:")]
        public Int32 ZipCode { get; set; }


        //--------------------NAVIGATIONAL PROPERTIES
        public List<Order> Orders { get; set; }
        public List<Property> Properties { get; set; }
        public List<Review> Reviews { get; set; }


        //--------------------PREVENT NULL PREFERENCE
        public AppUser()
        {
            if (Orders == null)
            {
                Orders = new List<Order>();
            }
            if (Properties == null)
            {
                Properties = new List<Property>();
            }
            if (Reviews == null)
            {
                Reviews = new List<Review>();
            }
        }

    }
}
