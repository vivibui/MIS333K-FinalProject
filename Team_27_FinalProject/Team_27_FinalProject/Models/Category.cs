﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Team_27_FinalProject.Models
{
    public class Category
    {
        [Display(Name = "Category: ")]
        public Int32 CategoryID { get; set; }

        [Required(ErrorMessage ="Category Name cannot be blank")]
        [Display(Name = "Category Name: ")]
        public String CategoryName { get; set; }


        //--------------------NAVIGATIONAL PROPERTIES
        public List<Property> Properties { get; set; }


        //--------------------PREVENT NULL PREFERENCE
        public Category()
        {
            if (Properties == null)
            {
                Properties = new List<Property>();
            }
        }
    }
}
