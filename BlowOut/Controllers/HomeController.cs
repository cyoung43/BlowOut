using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// THIS IS CHRIS TESTING OUT GITHUB!!!!!!
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
            ViewBag.Message = ".";

            return View();
        }

        public ActionResult Contact()
        {

            return RedirectToAction("Index", "Contact");
        }
    }
}