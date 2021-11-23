﻿using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;



namespace Team_27_FinalProject.Models
{
    public class AppUser : IdentityUser
    {
        //Primary Key
        public Int32 UserID { get; set; }

        //Name
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String MI { get; set; }

        //Email
        public String EmailAddress { get; set; }


        //Address and Zipcode
        public String Address { get; set; }

        public Int32 ZipCode { get; set; }

        //Phone number
        public Int32 Phone { get; set; }

        //Birthdate
        public DateTime Birthday { get; set; }

        //Active user?
        public Boolean IsActive { get; set; }

        //customer can have many orders
        public List<Order> Orders { get; set; }

        //Prevent Null reference    
        public AppUser()
        {
            if (Orders == null)
            {
                Orders = new List<Order>();
            }

        }
    }
}
