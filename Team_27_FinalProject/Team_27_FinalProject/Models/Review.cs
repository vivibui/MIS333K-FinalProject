﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Team_27_FinalProject.Models
{
    public class Review
    {
        public Int32 ReviewID { get; set; }

        public enum DisputeStatus { Pending, Accepted, Rejected }

        //Property Status
        [Required(ErrorMessage = "Property Status cannot be blank.")]
        [Display(Name = "Property Status:")]
        public DisputeStatus DStatus { get; set; }

        //Rating
        [Required(ErrorMessage = "Please enter your rating.")]
        [Display(Name = "Rating")]
        [Range(1, 5)]
        [DisplayFormat(DataFormatString = "{0:F0}")]
        public Decimal Rating { get; set; }

        //Content
        [Display(Name = "Review Description")]
        [StringLength(280, ErrorMessage = "The value cannot exceed 280 characters. ")]
        public String Content { get; set; }

        //Disputed
        [Display(Name = "Disputed?")]
        public Boolean IsDisputed { get; set; }

        //Dispute Reason
        [Display(Name = "Dispute Reason")]
        public String DisputeReason { get; set; }

        //--------------------NAVIGATIONAL PROPERTIES
        public AppUser AppUser { get; set; }
        public Property Property { get; set; }

    }
}


