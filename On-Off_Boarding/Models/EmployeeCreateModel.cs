using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace On_Off_Boarding.Models
{
    public class EmployeeCreateModel
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Enter the users first name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Enter the users last name")]
        public string LastName { get; set; }

        [Display(Name = "Shortname")]
        [Required(ErrorMessage = "Enter a proper shortname")]
        [StringLength(4, MinimumLength = 3, ErrorMessage = "Shortname should be 3-4 characters")]
        public string ShortName { get; set; }

        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "You need to assign an emailaddress for the user")]
        public string EmailAddress { get; set; }

        [Display(Name = "Exchange On-Prem")]
        public bool CreateEmailOnPrem { get; set; }

        [Display(Name = "Skype On-Prem")]
        public bool CreateSkypeOnPrem { get; set; }

        [Display(Name = "Title")]
        [Required(ErrorMessage = "Enter the users title")]
        public string Title { get; set; }

        [Display(Name = "Department")]
        [Required(ErrorMessage = "Enter which department the users is part of")]
        public string Department { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Office")]
        [Required(ErrorMessage = "Enter which office the users is part of")]
        public string Office { get; set; }

        [Display(Name = "Country")]
        public string Country { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Display(Name = "Office phone")]
        public string OfficePhone { get; set; }

        [Display(Name = "Reports to")]
        [Required(ErrorMessage = "Enter the employees manager")]
        public string ReportsTo { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password must be between 12-50 characters")]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 12, ErrorMessage = "Password must be between 12-50 characters")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and Confirm Password must match!")]

        public string ConfirmPassword { get; set; }
    }
}