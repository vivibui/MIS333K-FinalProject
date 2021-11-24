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
        private const Decimal TAX_RATE = 0.1m;

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
        [Range(1, 1000, ErrorMessage = "Number must be a positive integer.")]
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

        //Reservation Stay Price 
        [Display(Name = "Stay Price: ")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal StayPrice { get; set; }



        //--------------------NAVIGATIONAL PROPERTIES
        public Order Order { get; set; }
        public Property Property { get; set; }



        //--------------------START: CALCULATE STAY PRICE--------------------

        //Initialize empty list and variables
        List<DateTime> allDates = new List<DateTime>();
        private Int32 TotalWeekdays = 0;
        private Int32 TotalWeekends = 0;

        //List of Dates between Checkout and Checkin
        public IEnumerable<DateTime> DateRange()
        {

            for (DateTime i = CheckinDate; i < CheckoutDate; i = i.AddDays(1))
            {
                allDates.Add(i);
            }
            return allDates;
        }

        //Calculate total weekdays and weekends 
        public Decimal CalStayPrice()
        {
            foreach (var item in allDates)
            {
                if (item.DayOfWeek == DayOfWeek.Friday || item.DayOfWeek == DayOfWeek.Saturday)
                {
                    TotalWeekdays = TotalWeekdays + 1;
                }
                else
                {
                    TotalWeekends = TotalWeekends + 1; 
                }
            }

            //Calculate Stay Price 
            return (StayPrice = TotalWeekdays * WeekdayFee + TotalWeekends * WeekendFee);
        }

        //--------------------END: CALCULATE STAY PRICE--------------------


        //----------------------START: CALCULATE DISCOUNT-----------------------

        private bool? _IsDiscounted;

        //Is Discounted (T/F) (*)
        [Display(Name = "Discount Eligible? (T/F):")]
        public Boolean? IsDiscounted
        {
            get { return _IsDiscounted; }
            set
            {
                if (NumberOfNights > Property.DiscountMinNights)
                {
                    _IsDiscounted = true;
                }
                else
                {
                    _IsDiscounted = false;
                }
            }

        }

        //Discount (*)
        private decimal _discount;

        [Display(Name = "Discount Applied: ")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal Discount
        {
            get { return _discount; }
            set
            {
                if (_IsDiscounted == true)
                {
                    _discount = Subtotal * Property.DiscountRate;
                }
                else
                {
                    _discount = 0;
                }
            }
        }

        //----------------------END: CALCULATE DISCOUNT-----------------------

        //Number of Nights
        [Display(Name = "Number of Nights:")]
        public Int32 NumberOfNights
        {
            get { return ((CheckoutDate.Date - CheckinDate.Date).Days); }
        }

        //Reservation Subtotal
        [Display(Name = "Reservation Subtotal")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal Subtotal
        {
            get { return StayPrice - CleaningPrice - _discount; }
        }

        //Tax Fee
        [Display(Name = "Sales Tax (8.25%)")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal SalesTax
        {
            get { return Subtotal * TAX_RATE; }
        }

        //Reservation Total
        [Display(Name = "Reservation Total")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal ReservationTotal
        {
            get { return Subtotal + SalesTax; }
        }


        //--------------------FOR REPORTS-----------------------

        //Commission Rate 
        private const Decimal COMMISSION_RATE = 0.1m;

        //Commission (*) 
        [Display(Name = "Commission:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal Commission
        {
            get { return (Subtotal*COMMISSION_RATE); }
        }

        //Revenue (*)
        [Display(Name = "Host Revenue:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal HostRevenue
        {
            get { return (Subtotal - Commission); }
        }

    }
}
