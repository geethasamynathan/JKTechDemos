using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HtmlHelpersDemo1.Models;

namespace HtmlHelpersDemo1.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            List<Department> DepartmentList = new List<Department>()
            { new Department{Id=101,Name="HR"},
            new Department {Id=102,Name="IT"},
            new Department {Id=103,Name="Retail"}
            };
            ViewBag.departments = DepartmentList;
            Employee employee = new Employee()
            {
                EmployeeId = 1,
                EmployeeName = "Geetha",
                Gender = "Female",
                DepartmentId = 101
            };

            return View(employee);
        }

        [HttpGet]
        public ActionResult Create()
        {
            List<Department> DepartmentList = new List<Department>()
            { new Department{Id=101,Name="HR"},
            new Department {Id=102,Name="IT"},
            new Department {Id=103,Name="Retail"}
            };
            ViewBag.departments = DepartmentList;
            return View();
        }
        [HttpPost]
        public string Create(FormCollection formCollection,Employee employee)
        {
            string eid = formCollection[0].ToString();
            string ename = formCollection["EmployeeName"].ToString();
            string dept = formCollection[2].ToString();
            string empinfo = employee.EmployeeName + "added into the database";
            return empinfo;
        }
    }
}