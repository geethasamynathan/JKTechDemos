using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AuthorizeDemo.Models;

namespace AuthorizeDemo.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        UserEntities entities = new UserEntities();
        public ActionResult Login()
        {
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Login(User1 user)
        {
            if(ModelState.IsValid)
            {
                if (user.Username == "system" && user.Passsword == "admin")
                {
                    Session["username"] = user.Username;
                    FormsAuthentication.SetAuthCookie(user.Username, false);
                    return RedirectToAction("SecureMethod", "Home");

                }
                else
                    ModelState.AddModelError("","Invalid Credentials");
            }
            return View();
        }
        public ActionResult Logout()
        {
            Session["username"] = null;
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
        public ActionResult LoginCheck()
        {
            return View();
        }
        [HttpPost]
        public ActionResult  LoginCheck(USER user)
        {
            if (ModelState.IsValid)
            {
                //USER loggedinuser = new USER();
                USER loggedinuser = entities.USERS.FirstOrDefault(u => u.UserName == user.UserName.ToLower() && u.Password == user.Password.ToLower());
                if (loggedinuser != null)
                {
                    FormsAuthentication.SetAuthCookie(loggedinuser.UserName, false);
                    var authticket = new FormsAuthenticationTicket(
                        1, loggedinuser.UserName, DateTime.Now, DateTime.Now.AddMinutes(20), false, user.Roles);
                    string encryptticket = FormsAuthentication.Encrypt(authticket);
                    var authcookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptticket);
                    HttpContext.Response.Cookies.Add(authcookie);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("","Invalid credentials");

                }
            }
                return View();
        }
    }
}