using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HtmlHelpersDemo1.Models;
namespace HtmlHelpersDemo1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            List<Department> departments = new List<Department>()
            {   new Department{Id=1,Name="IT"},
                new Department{Id=2,Name="sales"},
                new Department{Id=3,Name="Purchase"},
            };
            //ViewBag.Departments = new SelectList(departments, "Id", "Name");

            //List<SelectListItem> items = new List<SelectListItem>();
            //items.Add(new SelectListItem { Text = "Admin", Value = "101"});
            //items.Add(new SelectListItem { Text = "Transport", Value = "102" });
            //items.Add(new SelectListItem { Text = "Entertain", Value = "103" });
            //ViewBag.departments = items;
            return View(departments);
        }
       
        public ActionResult Index1()
        {
            Company company = new Company();
            
            return View(company);
        }
        [HttpPost]
        public string Index1(Company company)
        {

            if (string.IsNullOrEmpty(company.SelectedDepartment))
                return "You have not selected any Department";
            else
                return "You have selected  : " + company.SelectedDepartment;
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}