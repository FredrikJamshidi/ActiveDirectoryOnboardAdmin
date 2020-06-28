using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataLibrary.Models
{
    public class EmployeeCreateModel
    {
        public int RequestID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ShortName { get; set; }
        public string EmailAddress { get; set; }
        public bool CreateEmailOnPrem { get; set; }
        public bool CreateSkypeOnPrem { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public string Description { get; set; }
        public string Office { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string OfficePhone { get; set; }
        public string ReportsTo { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Status { get; set; }
    }
}