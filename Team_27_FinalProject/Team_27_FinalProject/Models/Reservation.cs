using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Team_27_FinalProject.Models
{
    public class Reservation
    {
        //Primary key
        public Int32 ReservationID { get; set; }

        //Checkin Date
        [Display(Name = "Check-In Date:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMMM d, yyyy}")]
        public DateTime CheckinDate { get; set; }

        //Checkout Date
        [Display(Name = "Check-Out Date:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMMM d, yyyy}")]
        public DateTime CheckoutDate { get; set; }

        //Number of Guests
        [Required(ErrorMessage ="You must specify the total number of guests.")]
        [Display(Name = "Number of Guests:")]
        [Range(1, Property.Max(GuestsAllowed), ErrorMessage ="Number must be between 1 and total allowed.")]
        public Int32 NumberOfGuests { get; set; }

        //Number of Pets
        [Required(ErrorMessage = "You must specify the total number of pets.")]
        [Display(Name = "Number of Pets:")]
        [Range(0, Property.Max(PetsAllowed), ErrorMessage = "Quantity must be between 0 and total allowed.")]
        public Int32 NumberOfPets { get; set; }

        //----------Read-only Properties (Does not store in DB)
        //Number of Nights
        [Display(Name = "Number of Nights:")]
        public Int32 NumberOfNights
        {
            get { return ((CheckoutDate.Date - CheckinDate.Date).Days); }
        }

        //Reservation Subtotal
        [Display(Name = "Order Subtotal")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal OrderSubtotal
        {
            get { return OrderDetails.Sum(od => od.ExtendedPrice); }
        }

        //Tax Fee
        [Display(Name = "Sales Tax (8.25%)")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal SalesTax
        {
            get { return OrderSubtotal * TAX_RATE; }
        }

        //Order Total
        [Display(Name = "Order Total")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal OrderTotal
        {
            get { return OrderSubtotal + SalesTax; }
        }



        //Price
        [Required]
        [Display(Name = "Price:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal ProductPrice { get; set; }

        //Extended Price
        [Required]
        [Display(Name = "Extended Price:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal ExtendedPrice { get; set; }

        //Navigational Properties
        public Order Order { get; set; }
        public Product Product { get; set; }

    }
}
