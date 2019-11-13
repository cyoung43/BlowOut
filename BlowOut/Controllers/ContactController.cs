﻿using System;
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
            return View();
        }

        public ActionResult Email(string name, string email)
        {
            ViewBag.Email = "Thank you, " + name + ". We will email you at <u>" + email + "</u>";
            return View("Index");
        }
    }
}