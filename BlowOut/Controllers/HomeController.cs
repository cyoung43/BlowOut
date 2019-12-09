using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

// I JUST CHANGED THIS COMMENT. CAN YOU SEE ME!
namespace BlowOut.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Rentals()
        {

            return View();
        }

        public ActionResult Contact()
        {

            return RedirectToAction("Index", "Contact");

            //My name is bonnie and I like tacos
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection form, bool rememberMe = false)
        {
            String userName = form["UserName"].ToString();
            String password = form["Password"].ToString();

            if ((string.Equals(userName, "Missouri")) && (string.Equals(password, "ShowMe")))
            {
                FormsAuthentication.SetAuthCookie(userName, rememberMe);

                return RedirectToAction("UpdateData", "Orders");

            }
            else
            {
                ViewBag.Valid = "Invalid Credentials";
                return View();
            }
            
        }
    }
}

//This is me talking