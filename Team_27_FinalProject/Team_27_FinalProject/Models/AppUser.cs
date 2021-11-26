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
        public Boolean? IsActive { get; set; }

        //First Name
        [Display(Name = "First Name:")]
        public String FirstName { get; set; }

        //Last Name
        [Display(Name = "Last Name:")]
        public String LastName { get; set; }

        //Middle Name
        [Display(Name = "Middle Name:")]
        public String MI { get; set; }

        //Birthday
        [Display(Name = "Birthday")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMMM d, yyyy}")]
        public DateTime Birthday { get; set; }

        //Address
        [Display(Name = "Street:")]
        public String Street { get; set; }

        //Zipcode
        [RegularExpression(@"\d{5}", ErrorMessage = "Zipcode must be a 5-digit number.")]
        [Range(10000, 99999, ErrorMessage = "Please enter a valid zipcode range.")]
        [Display(Name = "Zip")]
        public Int32 Zip { get; set; }


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
