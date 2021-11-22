using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Team_27_FinalProject.Models
{
    public class Reservation
    {
        //Tax Rate 
        private const Decimal TAX_RATE = 0.0825m;

        //Primary key
        public Int32 ReservationID { get; set; }

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
        [Range(1, 1000000, ErrorMessage = "Number must be a positive integer.")]
        public Int32 NumberOfGuests { get; set; }

        // Cleaning Price (at time paid)
        [Required]
        [Display(Name = "Cleaning Price:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal CleaningPrice { get; set; }

        //WeekDay Fee (at time paid)
        [Required]
        [Display(Name = "Weekday Fee:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal WeekdayFee { get; set; }

        //Weekend Fee (at time paid) 
        [Required]
        [Display(Name = "Weekend Fee:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal WeekendFee { get; set; }

        //Is Discounted (T/F) (*)
        [Display(Name = "Discount Eligible? (T/F):")]
        public Boolean IsDiscounted { get; set; }

        //Discount (*) 
        [Display(Name = "Discount Applied: ")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal Discount { get; set; }


        //--------------------NAVIGATIONAL PROPERTIES
        public Order Order { get; set; }
        public Property Property { get; set; }



        //--------------------READ-ONLY (DOES NOT STORE IN DB) 

        //Number of Nights
        [Display(Name = "Number of Nights:")]
        public Int32 NumberOfNights
        {
            get { return ((CheckoutDate.Date - CheckinDate.Date).Days); }
        }

        //Reservation Stay Price 
        [Display(Name = "Stay Price: ")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal StayPrice
        {
            
        }

        //Reservation Subtotal
        [Display(Name = "Reservation Subtotal")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal Subtotal { get; set; }

        //Tax Fee
        [Display(Name = "Sales Tax (8.25%)")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal SalesTax
        {
            get { return Subtotal * TAX_RATE; }
        }

        //Order Total
        [Display(Name = "Order Total")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal ReservationTotal
        {
            get { return Subtotal + SalesTax; }
        }




        //--------------------READ-ONLY - FOR REPORTS (DOES NOT STORE IN DB)

        //Commission Rate 
        private const Decimal COMMISSION_RATE = 0.1m;

        //Commission (*) 
        [Display(Name = "Commission:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal Commission
        {
            get { return (ExtendedPrice*COMMISSION_RATE); }
        }

        //Revenue (*)
        [Display(Name = "Host Revenue:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal HostRevenue
        {
            get { return (ExtendedPrice - Commission); }
        }

    }
}
