using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Team_27_FinalProject.Models
{
    public class Booking
    {
        //Pass PropertyID
        public Int32 PropertyID { get; set; }

        //Checkin Date
        [Required(ErrorMessage = "Please select a check-in date .")]
        [Display(Name = "Check-In Date:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMMM d, yyyy}")]
        public DateTime CheckinDate { get; set; }

        //Checkout Date
        [Required(ErrorMessage = "Please select a check-out date .")]
        [Display(Name = "Check-Out Date:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMMM d, yyyy}")]
        public DateTime CheckoutDate { get; set; }

        //Number of Guests (*)
        [Required(ErrorMessage = "You must specify the total number of guests.")]
        [Display(Name = "Number of Guests:")]
        [Range(1, 1000, ErrorMessage = "Number must be a positive integer.")]
        public Int32 NumberOfGuests { get; set; }

    }

    public class LockDate
    {
        //Pass PropertyID
        public Int32 PropertyID { get; set; }

        //Checkin Date
        [Required(ErrorMessage = "Please select a date to start locking .")]
        [Display(Name = "Start Date:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMMM d, yyyy}")]
        public DateTime StartDate { get; set; }

        //Checkout Date
        [Required(ErrorMessage = "Please select a date that end locking.")]
        [Display(Name = "End Date:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMMM d, yyyy}")]
        public DateTime EndDate { get; set; }

    }
}
