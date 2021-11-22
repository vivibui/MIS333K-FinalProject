using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Team_27_FinalProject.Models
{    
    public class Property
    {
        //Primary key
        public Int32 PropertyID { get; set; }

        //Property Number
        [Display(Name = "Property Number:")]
        public Int32 PropertyNumber { get; set; }

        //Street
        [Required(ErrorMessage ="Street cannot be blank")]
        [Display(Name = "Street:")]
        public String Street { get; set; }

        //City
        [Required(ErrorMessage ="City cannot be blank")]
        [Display(Name = "City:")]
        public String City { get; set; }

        //State
        [Required(ErrorMessage ="State cannot be blank")]
        [StringLength(2, ErrorMessage = "Only allow 2 letters. Please enter state abbreviations.", MinimumLength = 2)]
        [Display(Name = "State:")]
        public String State { get; set; }

        //Zip
        [Required(ErrorMessage ="Zipcode cannot be blank")]
        [StringLength(5, ErrorMessage = "Zipcode must be 5 digits.", MinimumLength = 5)]
        [RegularExpression("[0-9]", ErrorMessage ="Zipcode must be number.")]
        [Display(Name = "Zipcode:")]
        public Int32 Zip { get; set; }

        //Bedrooms
        [Required(ErrorMessage = "Must specify number of bedrooms")]
        [Range(minimum:0, maximum:50, ErrorMessage ="Value must be between 0 and 50.")]
        [Display(Name = "Bedroom(s):")]
        public Int32 Bedrooms { get; set; }

        //Bathrooms
        [Required(ErrorMessage = "Must specify number of bathrooms")]
        [Range(minimum: 0, maximum: 50, ErrorMessage = "Value must be between 0 and 50.")]
        [Display(Name = "Bathroom(s):")]
        public Int32 Bathrooms { get; set; }

        //Pets Allowed
        [Required(ErrorMessage = "Must specify if pets are allowed.")]
        [Display(Name = "Pets Allowed? (T/F):")]
        public Boolean PetsAllowed { get; set; }

        //Guests Allowed
        [Required(ErrorMessage = "Must specify number of guests allowed.")]
        [Range(minimum: 0, maximum: 50, ErrorMessage = "Value must be between 0 and 50.")]
        [Display(Name = "Number of guests allowed:")]
        public Int32 GuestsAllowed { get; set; }

        //Free Parking
        [Required(ErrorMessage = "Must specify if parking is free.")]
        [Display(Name = "Free Parking? (T/F):")]
        public Boolean ParkingFree { get; set; }

        //Is Disabled (T/F) 
        [Display(Name = "Property Disabled? (T/F):")]
        public Boolean IsDiscounted { get; set; }

        //Weekday Price
        [Required(ErrorMessage = "Weekday price cannot leave blank.")]
        [Range(minimum: 0, maximum: 10000000, ErrorMessage = "Value cannot be negative.")]
        [Display(Name = "Weekday Price:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal WeekDayPrice { get; set; }

        //Weekend Price
        [Required(ErrorMessage = "Weekend price cannot leave blank.")]
        [Range(minimum: 0, maximum: 10000000, ErrorMessage = "Value cannot be negative.")]
        [Display(Name = "Weekend Price:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal WeekendPrice { get; set; }

        //Minimum Nights for Discount
        [Range(minimum: 0, maximum: 10000000, ErrorMessage = "Minimum nights cannot be negative.")]
        [Display(Name = "Minimum Nights for Discount:")]
        public Int32 DiscountMinNights { get; set; }

        //Discount Rate
        [Required(ErrorMessage = "Weekend price cannot leave blank.")]
        [Range(minimum: 0, maximum: 1, ErrorMessage = "Please enter a rate between 0 and 1. For example, 60% should be input as 0.6.")]
        [Display(Name = "Discount Rate:")]
        public Decimal DiscountRate { get; set; }

        //Cleaning Fee
        [Required(ErrorMessage = "Cleaning fee cannot leave blank.")]
        [Range(minimum: 0, maximum: 10000000, ErrorMessage = "Value cannot be negative.")]
        [Display(Name = "Cleaning Fee:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal CleaningFee { get; set; }


        //--------------------NAVIGATIONAL PROPERTIES
        public List<Review> Reviews { get; set; }
        public List<Reservation> Reservations { get; set; }
        public Category Category { get; set; }


        //--------------------PREVENT NULL PREFERENCE
        public Property()
        {
            if (Reviews == null)
            {
                Reviews = new List<Review>();
            }
            if (Reservations == null)
            {
                Reservations = new List<Reservation>();
            }
        }

        //--------------------READ-ONLY (DOES NOT STORE IN DB)

        //Ratings (*)
        [Required]
        [Display(Name = "Ratings:")]
        [DisplayFormat(DataFormatString = "{0:F1}")]
        public Decimal Ratings
        {
            get { return Reviews.Average(pt => pt.Rating); }
        }
    }
}
