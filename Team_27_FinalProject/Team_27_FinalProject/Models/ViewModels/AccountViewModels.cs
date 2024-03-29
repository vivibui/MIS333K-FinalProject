﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Team_27_FinalProject.Models
{ 
    //NOTE: This is the view model used to allow the user to login
    //The user only needs teh email and password to login
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    //NOTE: This is the view model used to register a user
    //When the user registers, they only need to specify the
    //properties listed in this model
    public class RegisterViewModel
    {
        //Email
        [Required]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        //Phone Number 
        [Required(ErrorMessage = "Phone number is required")]
        [Phone]
        [RegularExpression(@"\d{10}", ErrorMessage = "Phone number must be a 10-digit number.")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        //Birthday
        [Required(ErrorMessage = "Please enter your birthday.")]
        [Display(Name = "Birthday")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMMM d, yyyy}")]
        public DateTime Birthday { get; set; }

        //First Name
        [Required(ErrorMessage = "First name is required.")]
        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        //Middle Name
        [Required(ErrorMessage = "Middle name is required.")]
        [Display(Name = "Middle Name")]
        public String MI { get; set; }

        //Last Name
        [Required(ErrorMessage = "Last name is required.")]
        [Display(Name = "Last Name")]
        public String LastName { get; set; }

        //Street
        [Required(ErrorMessage = "Address cannot be blank.")]
        [Display(Name = "Street")]
        public String Street { get; set; }

        //Zipcode 
        [Required(ErrorMessage = "Please enter a 5-digit number. Zipcode cannot be blank.")]
        [RegularExpression(@"\d{5}", ErrorMessage = "Zipcode must be a 5-digit number.")]
        [Range(10000, 99999, ErrorMessage = "Please enter a valid zipcode range.")]
        [Display(Name = "Zip")]
        public Int32 Zip { get; set; }

        //Register Password
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        //Confirm Password 
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    //NOTE: This is the view model used to allow the user to 
    //change their password
    public class ChangePasswordViewModel
    {

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

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

    //NOTE: This is the view model used to display basic user information
    //on the index page
    public class IndexViewModel
    {

        //First Name
        public String FirstName { get; set; }

        //Last Name
        public String LastName { get; set; }

        //Phone
        [Phone]
        [RegularExpression(@"\d{10}", ErrorMessage = "Phone number must be a 10-digit number.")]
        public string PhoneNumber { get; set; }

        public bool HasPassword { get; set; }
        public String UserName { get; set; }
        public String Email { get; set; }
        public String UserID { get; set; }

        //Street
        public String Street { get; set; }

        //Zipcode 
        public Int32 Zip { get; set; }

        //Birthday
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
    }

    //NOTE: This is the view model used to allow the user to 
    //change their birthday
    public class ChangeBirthdayViewModel
    {
        [Required(ErrorMessage = "Please enter your birthday.")]
        [Display(Name = "Birthday")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMMM d, yyyy}")]
        public DateTime Birthday { get; set; }
    }

    //NOTE: This is the view model used to allow the user to 
    //change their address
    public class ChangeAddressViewModel
    {
        //Street
        [Required(ErrorMessage = "Address cannot be blank.")]
        [Display(Name = "Street")]
        public String Street { get; set; }

        //Zipcode 
        [Required(ErrorMessage = "Please enter a 5-digit number. Zipcode cannot be blank.")]
        [RegularExpression(@"\d{5}", ErrorMessage = "Zipcode must be a 5-digit number.")]
        [Range(10000, 99999, ErrorMessage = "Please enter a valid zipcode range.")]
        [Display(Name = "Zip")]
        public Int32 Zip { get; set; }
    }

    //NOTE: This is the view model used to allow the user to 
    //change their phone
    public class ChangePhoneViewModel
    {
        [Required(ErrorMessage = "Phone number is required")]
        [Phone]
        [RegularExpression(@"\d{10}", ErrorMessage = "Phone number must be a 10-digit number.")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
    }
}
