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

            //rating
            //decimal between 1.0 and 5.0
            //calculate average rating in ReviewsController? HomeController?
            //need a searchviewmodel to specify greaterthan/lessthan
            //HomeController handles Search Rating (HW3)
            [Required]
            [Display(Name = "Rating")]
            [Range(1.0, 5.0)]
            [DisplayFormat(DataFormatString = "{0:C1")]
            public Decimal Rating { get; set; }

            //Content
            [Required]
            [Display(Name = "Review Content")]
            public String Content { get; set; }

            //Disputed
            [Display(Name = "Disputed?")]
            public Boolean Disputed { get; set; }

            //Dispute Reason
            [Display(Name = "Dispute Reason")]
            public String DisputeReason { get; set; }


            //--------------------NAVIGATIONAL PROPERTIES
            public AppUser AppUser { get; set; }
            public Property Property { get; set; }

        }
    }
}
}
