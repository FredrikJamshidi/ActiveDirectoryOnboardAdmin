using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Logic
{
    public class EmployeeCreationProcessor
    {
        public static string CreateUser(string firstName,string lastName, string emailAddress,string shortName, string title, string department, string description, string office, string country, string phone, string officePhone, string address, string zipCode, string state, string city, string reportsTo, string password)
        {

            EmployeeCreateModel Employee = new EmployeeCreateModel
            {
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = emailAddress,
                ShortName = shortName,
                Title = title,
                Department = department,
                Description = description,
                Office = office,
                Country = country,
                Phone = phone,
                OfficePhone = officePhone,
                Address = address,
                ZipCode = zipCode,
                State = state,
                City = city,
                ReportsTo = reportsTo,
                Password = password
            };

            return "";
        }
    }
}
