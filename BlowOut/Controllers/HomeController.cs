using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// changed comment again we are getting it! YAY!
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
    }
}

//This is me talking