using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Team_27_FinalProject.Models
{ 
    public class EditUserViewModel
    {
        //IsActive (Y/N)
        [Display(Name = "Is Active? (Y/N)")]
        public Boolean? IsActive { get; set; }

        //Email
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        //Phone Number 
        [Phone]
        [RegularExpression(@"\d{10}", ErrorMessage = "Phone number must be a 10-digit number.")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        //Birthday
        [Display(Name = "Birthday")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMMM d, yyyy}")]
        public DateTime Birthday { get; set; }

        //First Name
        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        //Middle Name
        [Display(Name = "Middle Name")]
        public String MI { get; set; }

        //Last Name
        [Display(Name = "Last Name")]
        public String LastName { get; set; }

        //Street
        [Display(Name = "Street")]
        public String Street { get; set; }

        //Zipcode 
        [Required(ErrorMessage = "Please enter a 5-digit number. Zipcode cannot be blank.")]
        [RegularExpression(@"\d{5}", ErrorMessage = "Zipcode must be a 5-digit number.")]
        [Range(10000, 99999, ErrorMessage = "Please enter a valid zipcode range.")]
        [Display(Name = "Zip")]
        public Int32 Zip { get; set; }

    }

    public class ChangePasswordAdminViewModel
    {

        public string Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

}
