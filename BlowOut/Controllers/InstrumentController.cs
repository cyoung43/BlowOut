using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class InstrumentController : Controller
    {
        // GET: Instrument
        public ActionResult Trumpet()
        {
            return View();
        }

        public ActionResult NewTrumpet()
        {
            ViewBag.New = "New: $55 per month";
            return View("Trumpet");
        }

        public ActionResult UsedTrumpet()
        {
            ViewBag.Used = "Used: $35 per month";
            return View("Trumpet");
        }

        public ActionResult Tuba()
        {
            return View();
        }

        public ActionResult Trombone()
        {
            return View();
        }

        public ActionResult Clarinet()
        {
            return View();
        }

        public ActionResult Flute()
        {
            return View();
        }

        public ActionResult Saxophone()
        {
            return View();
        }
    }
}