using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResultypesDemo.Controllers
{
    public class HomeController : Controller
    {
        // example for ViewResult
        //public ViewResult Index()
        //{
        //    ViewBag.ItemList = "Computer Shop Item List Page";
        //    return View();
        //}
        //example for Empty Result
        //public EmptyResult Index()
        //{
        //    ViewBag.ItemList = "Computer Shop Item List Page";
        //    return new EmptyResult();
        //}
        //RedirectResult
        /* Redirect Results is used for returning results to specific url.When you need to redirect to another 
         * action method, you can use RedirectResult Action Method.
         * */
        //public RedirectResult Index()
        //{
        //    return Redirect("Home/Contact");
        //}
        //public ActionResult Index()
        //{
        //    return View();
        //}
        //JSONResult
        /*
         * JSON Result returns simple text file format and key value pairs. Sometimes you may want to 
         * return data in JSON Format and that situation you JSONResult is the best option.*/
        //public JsonResult index()
        //{
        //    List<Employee> emplist = new List<Employee>();
        //    Employee emp1 = new Employee()
        //    {
        //        ID = "emp23",
        //        Name = "steven clark",
        //        Mobile = "825415426"
        //    };
        //    Employee emp2 = new Employee()
        //    {
        //        ID = "emp24",
        //        Name = "St.Joseph",
        //        Mobile = "82541542326"
        //    };
        //    emplist.Add(emp1);
        //    emplist.Add(emp2);
        //    return Json(emplist, JsonRequestBehavior.AllowGet);
        //  //  return View(emplist);
        //}
     
        public class Employee
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public string Mobile { get; set; }
        }
        //JavaScriptResult
        /*/*
         * It returns java script that can be executed on the client browser.
         * It sends javascript content in response to browser. This block allow you to execute java script on client at run time.
         * */


        //public ContentResult Index()
        //{
        //    return Content("Hello ASP.NET MVC 5");
        //}
        //[HttpGet]
        //public FileResult Index()
        //{
        //    string filepath = @"E:\C#.Net Notes Console\collections.txt";
        //    string contentype = "text";
        //    return File(filepath, contentype);
          
        //}
        //public FileResult DownloadFile()
        //{
        //    string filepath = @"E:\C#.Net Notes Console\collections.txt";
        //    string contentype = "text";
        //    byte[] fileinfo = System.IO.File.ReadAllBytes(filepath);
        //    return File(fileinfo,contentype,"sampleCollections.txt");

        //}

        public ActionResult Index()
        {
            return View();
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