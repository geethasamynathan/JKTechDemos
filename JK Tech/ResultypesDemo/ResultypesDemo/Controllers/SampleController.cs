using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;


namespace ResultypesDemo.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        //public RedirectResult Index()
        //{
        //    return Redirect("https://www.msdn.com");
        //}

        //public RedirectToRouteResult Index()
        //{
        //   return RedirectToAction("About");

        //}
        //public RedirectToRouteResult Index()
        //{
        //    return RedirectToRoute(new { Controller = "Home", Action = "Contact" });

        //}

        public HttpStatusCodeResult Index()
        {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest,"Something went wrong. Please contact admin");
        }
    }
}