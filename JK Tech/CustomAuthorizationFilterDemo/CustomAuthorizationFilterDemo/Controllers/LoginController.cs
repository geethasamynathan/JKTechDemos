using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomAuthorizationFilterDemo.Models;
using System.Web.Security;
namespace CustomAuthorizationFilterDemo.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        JkTech_CF_DBEntities context = new JkTech_CF_DBEntities();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(USER user)
        {
            if (ModelState.IsValid)
            {
                UserRepository repository = new UserRepository();
                USER loggedinuser = repository.GetUserDetails(user.UserName, user.Password);
                if (loggedinuser != null)
                {
                    FormsAuthentication.SetAuthCookie(loggedinuser.UserName, false);
                 
                    var authtickect = new FormsAuthenticationTicket(1, loggedinuser.UserName,
                        DateTime.Now, DateTime.Now.AddMinutes(10), false, loggedinuser.Roles);
                    string encrypttext = FormsAuthentication.Encrypt(authtickect);
                    var authcookie = new HttpCookie(FormsAuthentication.FormsCookieName, encrypttext);
                    HttpContext.Response.Cookies.Add(authcookie);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid login attempt.");
                    return View(user);
                }
            }
            return View(user);
          
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}