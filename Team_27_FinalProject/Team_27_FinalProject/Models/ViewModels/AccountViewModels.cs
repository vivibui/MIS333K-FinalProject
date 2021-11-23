using System.Collections.Generic;
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
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        //Phone Number 
        [Required(ErrorMessage = "Phone number is required")]
        [Phone]
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
        [Required(ErrorMessage = "Street cannot be blank.")]
        [Display(Name = "Street:")]
        public String Street { get; set; }

        //City
        [Required(ErrorMessage = "City cannot be blank.")]
        [Display(Name = "City:")]
        public String City { get; set; }

        //State
        [Required(ErrorMessage = "State cannot be blank.")]
        [StringLength(2, ErrorMessage = "Only allow 2 letters. Please enter state abbreviations.", MinimumLength = 2)]
        [Display(Name = "State:")]
        public String State { get; set; }

        //Zipcode 
        [Required(ErrorMessage = "Zipcode cannot be blank.")]
        [StringLength(5, ErrorMessage = "Zipcode must be 5 digits.", MinimumLength = 5)]
        [RegularExpression("[0-9]", ErrorMessage = "Zipcode must be a 5-digit number.")]
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
        public bool HasPassword { get; set; }
        public String UserName { get; set; }
        public String Email { get; set; }
        public String UserID { get; set; }
    }
}
