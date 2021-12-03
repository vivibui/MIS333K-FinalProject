using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Team_27_FinalProject.Models
{

    public class Order
    {
        public enum OrderStatus { Completed, Pending, Cancelled}

        //Tax Rate 
        private const Decimal TAX_RATE = 0.1m;

        //Order Status
        [Required(ErrorMessage = "Order Status cannot be blank.")]
        [Display(Name = "Order Status:")]
        public OrderStatus OStatus { get; set; }

        //Primary key
        public Int32 OrderID { get; set; }

        //Order Number
        [Display(Name = "Order Number:")]
        public Int32 OrderNumber { get; set; }

        //Order Date
        [Display(Name = "Order Date:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMMM d, yyyy}")]
        public DateTime OrderDate { get; set; }

        //Is Canncelled (T/F) 
        [Display(Name = "Cancelled?:")]
        public Boolean IsCancelled { get; set; }


        //--------------------NAVIGATIONAL PROPERTIES
        public List<Reservation> Reservations { get; set; }
        public AppUser AppUser { get; set; }



        //--------------------PREVENT NULL PREFERENCE
        public Order()
        {
            if (Reservations == null)
            {
                Reservations = new List<Reservation>();
            }
        }



        //--------------------READ-ONLY (DOES NOT STORE IN DB)
        
        //Order Subtotal
        [Display(Name = "Order Subtotal")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal OrderSubtotal
        {
            get { return Reservations.Sum(rs => rs.Subtotal); }
        }

        //Tax Fee
        [Display(Name = "Sales Tax (10%)")]
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


        //--------------------FOR THE REPORT
        //Sum Earning
        //[Display(Name = "Sum Earning")]
        //[DisplayFormat(DataFormatString = "{0:C}")]
        //public Decimal SumEarning
        //{
        //    get { return Reservations.Sum(r => r.TotalEarning); }
        //}
    }
}