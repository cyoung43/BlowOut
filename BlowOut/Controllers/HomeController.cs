﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
        }
    }
}

//This is me talking