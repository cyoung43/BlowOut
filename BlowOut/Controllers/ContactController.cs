using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            ViewBag.String = "Please call Support at <strong><u>801-555-1212</u></strong>. Thank you!";
            ViewBag.Email = "To get an email from BlowOut, enter your email in the URL followed by a '/' then your name.";
            return View();
        }

        public ActionResult Email(string email, string name)
        {
            ViewBag.Email = "Thank you, " + name + ". We will email you at <u>" + email + "</u>";
            return View("Index");
        }
    }
}