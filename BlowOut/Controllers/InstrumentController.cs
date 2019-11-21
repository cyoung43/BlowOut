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
            ViewBag.PriceInfo = "New: $55 per month";
            return View("Trumpet");
        }

        public ActionResult UsedTrumpet()
        {
            ViewBag.PriceInfo = "Used: $25 per month";
            return View("Trumpet");
        }

        public ActionResult Tuba()
        {
            return View();
        }

        public ActionResult TubaNew()
        {
            ViewBag.PriceInfo = "New: $70 a month";
            return View("Tuba");
        }

        public ActionResult TubaUsed()
        {
            ViewBag.PriceInfo = "Used: $50 a month";
            return View("Tuba");
        }

        public ActionResult Trombone()
        {
            return View();
        }

        public ActionResult TromboneNew()
        {
            ViewBag.PriceInfo = "New: $60 a month";
            return View("Trombone");
        }

        public ActionResult TromboneUsed()
        {
            ViewBag.PriceInfo = "Used: $35 a month";
            return View("Trombone");
        }

        public ActionResult Clarinet()
        {
            return View();
        }

        public ActionResult ClarinetNew()
        {
            ViewBag.PriceInfo = "New: $35 a month";
            return View("Clarinet");
        }

        public ActionResult ClarinetUsed()
        {
            ViewBag.PriceInfo = "Used: $27 a month";
            return View("Clarinet");
        }

        public ActionResult Flute()
        {
            return View();
        }

        public ActionResult FluteNew()
        {
            ViewBag.PriceInfo = "New: $40 a month";
            return View("Flute");
        }

        public ActionResult FluteUsed()
        {
            ViewBag.PriceInfo = "Used: $25 a month";
            return View("Flute");
        }

        public ActionResult Saxophone()
        {
            return View();
        }

        public ActionResult SaxophoneNew()
        {
            ViewBag.PriceInfo = "New: $42 a month";
            return View("Saxophone");
        }

        public ActionResult SaxophoneUsed()
        {
            ViewBag.PriceInfo = "Used: $30 a month";
            return View("Saxophone");
        }
    }
}