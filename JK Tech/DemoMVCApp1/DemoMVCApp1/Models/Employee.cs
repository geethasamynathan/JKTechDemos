using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoMVCApp1.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set;}
        public  string  Gender { get; set; }
        public int AddressId { get; set; }
    }
}