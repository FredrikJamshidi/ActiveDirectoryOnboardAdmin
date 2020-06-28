using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace On_Off_Boarding.Models
{
    public class EmployeeRequestModel
    {
        public int RequestID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You need to enter the users first name.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You need to enter the users last name.")]
        public string LastName { get; set; }

        [Display(Name = "Prefered Email Address")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Display(Name = "Title")]
        [Required(ErrorMessage = "You need to enter the users title.")]
        public string Title { get; set; }

        [Display(Name = "Department")]
        [Required(ErrorMessage = "You need to enter which department the users is part of.")]
        public string Department { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Office")]
        [Required(ErrorMessage = "You need to enter which office the users is part of.")]
        public string Office { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "You need to enter which country the user is hired in.")]
        public string Country { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "You need to enter the office address.")]
        public string Address { get; set; }

        [Display(Name = "Zip Code")]
        [Required(ErrorMessage = "You need to enter the zip code to the office address.")]
        public string ZipCode { get; set; }

        [Display(Name = "State")]
        [Required(ErrorMessage = "You need to enter the state of the office address.")]
        public string State { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "You need to enter the city of the office address.")]
        public string City { get; set; }

        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Display(Name = "Office phone")]
        public string OfficePhone { get; set; }

        [Display(Name = "Reports to")]
        [Required(ErrorMessage = "You need to enter the manager of the employee.")]
        public string ReportsTo { get; set; }

        [Display(Name = "Start date")]
        [Required(ErrorMessage = "You need to enter the date of when the users starts.")]
        [DataType(DataType.Date)]
        public string StartDate { get; set; }

        [Display(Name = "Comment")]
        [StringLength(50, MinimumLength = 0, ErrorMessage = "Comment to long")]
        public string Comment { get; set; }
        public string Status { get; set; } = "Registered";
    }
}