using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI.WebControls;

namespace LTQL_1721050486.Controllers
{
    public class LoginsController : Controller
    {
        // GET: Logins
        public ActionResult Login()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Login(Login login)
        {
            if (login.UserName == "Admin" && login.Password == "123456")
            {
                FormsAuthentication.SetAuthCookie(login.UserName, true);
                return RedirectToAction("About", "Home");
            }
            return View();

        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}