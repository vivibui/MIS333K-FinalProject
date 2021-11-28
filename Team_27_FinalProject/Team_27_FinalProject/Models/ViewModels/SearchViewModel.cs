using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Team_27_FinalProject.Models
{
    public enum RatingType {GreaterThan, LessThan}

    public class SearchViewModel
    {
        //Text: City
        [Display(Name = "Search by City:")]
        public String SelectedCity { get; set; }

        //Text: State
        [Display(Name = "Seach by State:")]
        public String SelectedState { get; set; }

        //Date picker: Check-in Date
        [Display(Name = "Select Check-in:")]
        [DataType(DataType.Date)]
        public DateTime? SelectedCheckin { get; set; }

        //Date picker: Check-out Date (*) 
        [Display(Name = "Select Check-out:")]
        [DataType(DataType.Date)]
        public DateTime? SelectedCheckout { get; set; }

        //Textbox: Ratings
        [Display(Name = "Search by Rating:")]
        public Decimal? SelectedRating { get; set; }

        //Options - Enum: Ratings  
        [Display(Name = "Filter Rating:")]
        public RatingType RatingType { get; set; }

        //Textbox: Number of Guests
        [Display(Name = "Search by Number of Guests:")]
        public Int32? SelectedGuests { get; set; }

        //Textbox: Price
        [Display(Name = "Search by Price:")]
        public Decimal? SelectedPrice { get; set; }

        //Drop-down: Categories 
        [Display(Name = "Type of Property:")]
        public Int32 SelectedCategoryID { get; set; }

        //Textbox: Number of bedrooms (exact, min, max, both)
        [Display(Name = "Search by Number of Bedrooms:")]
        public Int32? SelectedBedrooms { get; set; }
        [Display(Name = "Minimum bedrooms")]
        public Int32? SelectedMinBedrooms { get; set; }
        [Display(Name = "Maximum bedrooms")]
        public Int32? SelectedMaxBedrooms { get; set; }

        //Textbox: Number of bathrooms (exact, min, max, or both)
        [Display(Name = "Search by Number of Bathrooms:")]
        public Int32? SelectedBathrooms { get; set; }
        [Display(Name = "Minimum bathrooms")]
        public Int32? SelectedMinBathrooms { get; set; }
        [Display(Name = "Maximum bathrooms")]
        public Int32? SelectedMaxBathrooms { get; set; }

        //Options: Pets Allowed (Y/N)
        [Display(Name = "Pets Allowed:")]
        public Boolean SelectedPets { get; set; }

        //Options: Free Parking (Y/N)
        [Display(Name = "Free Parking:")]
        public Boolean SelectedParking { get; set; }

    }
}
