using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HtmlHelpersDemo1.Models
{
    public class Company
    {
        public string SelectedDepartment { get; set; }
        public List<Department> Departments
        {
            get
            {
                List<Department> ListDepartments = new List<Department>()
                { new Department() {Id=1, Name="Sales" },
                 new Department() {Id=1, Name="Purchase" },
                  new Department() {Id=1, Name="Transport" }
                };
                return ListDepartments;

            }
        }
    }
}