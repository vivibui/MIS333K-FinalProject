using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Team_27_FinalProject.Models
{
    public class AppUser:IdentityUser
    {
        //IsActive (Y/N)
        public Boolean IsActive { get; set; }

        //First Name
        public String FirstName { get; set; }

        //Last Name
        public String LastName { get; set; }

        //Middle Name
        public String MI { get; set; }

        //Birthday 
        public DateTime Birthday { get; set; }

        //Address
        public String Address { get; set; }

        //Zipcode 
        public Int32 ZipCode { get; set; }


        //--------------------NAVIGATIONAL PROPERTIES
        public List<Order> Orders { get; set; }
        public List<Property> Properties { get; set; }
        public List<Review> Reviews { get; set; }

    }
}
