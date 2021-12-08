using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DemoMVCApp1.Models;

namespace DemoMVCApp1.ViewModels
{
    public class EmployeeViewModel
    {
        public Employee Employee { get; set; } 
        public Address Address { get; set; }
        public string PageTitle { get; set; }
    }
}