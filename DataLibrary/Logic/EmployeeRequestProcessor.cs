using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Logic
{
    public static class EmployeeRequestProcessor
    {
        public static int CreateEmployeeRequest(string firstName, string lastName, string emailAddress, string title, string department, string description, string office, string country, string phone, string officePhone, string address, string zipCode, string state, string city, string reportsTo, string startDate, string comment, string status)
        {
            EmployeeRequestModel data = new EmployeeRequestModel
            {
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = emailAddress,
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
                StartDate = startDate,
                Comment = comment,
                Status = status
            };

            string sql = @"insert into EmployeeRequests (FirstName, LastName, EmailAddress, Title, Department, Description, Office, Country, Phone, OfficePhone, Address, ZipCode, State, City, ReportsTo, StartDate, Comment, Status) values 
                        (@FirstName, @LastName, @EmailAddress, @Title, @Department, @Description, @Office, @Country, @Phone, @OfficePhone, @Address, @ZipCode, @State, @City, @ReportsTo, @StartDate, @Comment, @Status)";

            return SqliteDataAccess.SaveData(sql, data);
        }

        public static List<EmployeeRequestModel> LoadEmployeeRequests()
        {
            string sql = @"select * from EmployeeRequests";

            return SqliteDataAccess.LoadData<EmployeeRequestModel>(sql);
        }

        public static List<EmployeeCreateModel> LoadSpecificRequest(int requestID)
        {
            string sql = $@"select * from EmployeeRequests where RequestID = {requestID}";

            return SqliteDataAccess.LoadData<EmployeeCreateModel>(sql);
        }
    }
}
