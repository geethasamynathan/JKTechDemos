using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoMVCApp1.Models;
using DemoMVCApp1.ViewModels;

namespace DemoMVCApp1.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            List<Employee> EmployeeList = new List<Employee>();
            Employee employee1 = new Employee() { Id = 101, Name = "Pankaj", Designation = "Designer" };
            Employee employee2 = new Employee() { Id = 102, Name = "shalini", Designation = "Jr.Developer" };
            Employee employee3 = new Employee() { Id = 103, Name = "Peter", Designation = "Sr.Architect" };
            EmployeeList.Add(employee1);
            EmployeeList.Add(employee2);
            EmployeeList.Add(employee3);
            return View(EmployeeList);
             
        }
       public ActionResult Details()
        {
            Employee employee = new Employee() { Id = 101, Name = "Pankaj", Designation = "Designer" };
            Address address = new Address() { AddressId = 1, City = "CBE", State = "TN", Country = "India" };
            EmployeeViewModel viewModel = new EmployeeViewModel();
            viewModel.Employee = employee;
            viewModel.Address = address;
            viewModel.PageTitle = " Employee Information";
            
            return View(viewModel);
        }
    }
}