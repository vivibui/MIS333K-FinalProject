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

        //Street
        public String Street { get; set; }

        //City
        public String City { get; set; }

        //State
        public String State { get; set; }

        //Zipcode 
        public Int32 Zip { get; set; }


        //--------------------NAVIGATIONAL PROPERTIES
        public List<Order> Orders { get; set; }

    }
}
