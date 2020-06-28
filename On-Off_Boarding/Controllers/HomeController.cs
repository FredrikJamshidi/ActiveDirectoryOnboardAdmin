using On_Off_Boarding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using static DataLibrary.Logic.EmployeeRequestProcessor;
using System.Net;

namespace On_Off_Boarding.Controllers
{
    public class HomeController : Controller
    {

        // TODO: Create backend to create the user in Acitve Directory & Exchange & SkypeForBussiness
        //       Create backend to connect to Azure and assign license
        //       Create Backend to migrate user from Exchange On-Prem to Exchange Online
        //       Create Backend to migrate user from Skype On-Prem to Skype/Teams Online

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EmployeeRequest()
        {
            ViewBag.Message = "Employee Request";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EmployeeRequest(EmployeeRequestModel model)
        {
            if (ModelState.IsValid)
            {
                int created = CreateEmployeeRequest(model.FirstName,
                   model.LastName,
                   model.EmailAddress,
                   model.Title,
                   model.Department,
                   model.Description,
                   model.Office,
                   model.Country,
                   model.Phone,
                   model.OfficePhone,
                   model.Address,
                   model.ZipCode,
                   model.State,
                   model.City,
                   model.ReportsTo,
                   model.StartDate,
                   model.Comment,
                   model.Status);
                return RedirectToAction("EmployeeRequestCreated");
            }

            return View();
        }

        public ActionResult EmployeeRequestCreated()
        {
            ViewBag.Message = "Employee Request Created";

            return View();
        }

        public ActionResult ViewRequests()
        {
            ViewBag.Message = "Employee Request List";

            var data = LoadEmployeeRequests();

            List<EmployeeRequestModel> employeeRequests = new List<EmployeeRequestModel>();

            foreach(var row in data)
            {
                employeeRequests.Add(new EmployeeRequestModel
                {
                    RequestID = row.RequestID,
                    FirstName = row.FirstName,
                    LastName = row.LastName,
                    EmailAddress = row.EmailAddress,
                    Title = row.Title,
                    Department = row.Department,
                    Description = row.Description,
                    Office = row.Office,
                    Country = row.Country,
                    Phone = row.Phone,
                    OfficePhone = row.OfficePhone,
                    Address = row.Address,
                    ZipCode = row.ZipCode,
                    State = row.State,
                    City = row.City,
                    ReportsTo = row.ReportsTo,
                    StartDate = row.StartDate,
                    Comment = row.Comment,
                    Status = row.Status
                });
            }

            return View(employeeRequests);
        }

        public ActionResult EmployeeCreate(int id)
        {
            ViewBag.Message = "Create Employee";

            var data = LoadSpecificRequest(id);

            EmployeeCreateModel employeeRequest = new EmployeeCreateModel();

            foreach (var row in data)
            {
                employeeRequest.FirstName = row.FirstName;
                employeeRequest.LastName = row.LastName;
                employeeRequest.EmailAddress = row.EmailAddress;
                employeeRequest.Title = row.Title;
                employeeRequest.Department = row.Department;
                employeeRequest.Description = row.Description;
                employeeRequest.Office = row.Office;
                employeeRequest.Country = row.Country;
                employeeRequest.Phone = row.Phone;
                employeeRequest.OfficePhone = row.OfficePhone;
                employeeRequest.Address = row.Address;
                employeeRequest.ZipCode = row.ZipCode;
                employeeRequest.State = row.State;
                employeeRequest.City = row.City;
                employeeRequest.ReportsTo = row.ReportsTo;
            }

            return View(employeeRequest);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EmployeeCreate(EmployeeCreateModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("ViewRequests");
            }

            return View();
        }
    }
}