using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVCApp1.Controllers
{
    public class StudentsController : Controller
    {
        public ActionResult Method1()
        {
            TempData["Name"] = "Ifour";
            TempData["Age"] = 21;
            TempData.Keep();
            return View();
        }
        public ActionResult Method2()
        {
            string Name =TempData["Name"].ToString();
            int Age;
            if (TempData.ContainsKey("Name"))
                Name = TempData["Name"].ToString();
            if (TempData.ContainsKey("Age"))
                Age = int.Parse(TempData["Age"].ToString());
            TempData.Keep();
            return View();
        }
        public ActionResult Method3()
        {
            string Name;
            int Age;
            if (TempData.ContainsKey("Name"))
                Name = TempData["Name"].ToString();
            if (TempData.ContainsKey("Age"))
                Age = int.Parse(TempData["Age"].ToString());
            return View();
        }
    }
}