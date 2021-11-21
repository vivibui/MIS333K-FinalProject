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









        //Name
        [Required]
        [Display(Name = "Product Name:")]
        public String ProductName { get; set; }

        //Description
        [Display(Name = "Product Description:")]
        public String Description { get; set; }

        //Price
        [Required]
        [Display(Name = "Product Price:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal Price { get; set; }

        //Type
        [Display(Name = "Product Type:")]
        public Type ProductType { get; set; }

        //Navigational Properties
        public List<Supplier> Suppliers { get; set; }

        internal static double Max(object guestsAllowed)
        {
            throw new NotImplementedException();
        }

        public List<OrderDetail> OrderDetails { get; set; }

        //Prevent null preference
        public Product()
        {
            if (Suppliers == null)
            {
                Suppliers = new List<Supplier>();
            }
            if (OrderDetails == null)
            {
                OrderDetails = new List<OrderDetail>();
            }
        }
    }
}
