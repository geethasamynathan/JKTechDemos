using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionFiltersDemo.Controllers
{
    [HandleError(ExceptionType =typeof(DivideByZeroException),View ="Devidebyzero")]
    [HandleError (ExceptionType =typeof(NullReferenceException),View ="Nullreference")]
    public class HomeController : Controller
    {
    
        //public ActionResult Index()
        //{
        //    throw new Exception(" Something Went wrong");
        // //   return View();
        //}

        //public ActionResult Method1()
        //{
        //    throw new DivideByZeroException();
        //}
        //public ActionResult Method2()
        //{
        //    throw new NullReferenceException();
        //}
        //public ActionResult Method3()
        //{
        //    throw new Exception();
        //}

        //Demo2 : ChildActiononly
        public ActionResult Index()
        {
            List<string> ctyname = new List<string>() { "Indai", "Japan", "German" };
            
            return View();
        }
       //[NonAction]
       [ChildActionOnly]
        public  ActionResult Countries(List<string> countrynames)
        {
            return View(countrynames);
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