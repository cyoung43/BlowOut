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

        public ActionResult TrumpetNew()
        {
            ViewBag.PriceInfo = "$55 a month";
            return View("Trumpet");
        }

        public ActionResult TrumpetUsed()
        {
            ViewBag.PriceInfo = "$25 a month";
            return View("Trumpet");
        }

        public ActionResult Tuba()
        {
            return View();
        }

        public ActionResult TubaNew()
        {
            ViewBag.PriceInfo = "$70 a month";
            return View("Tuba");
        }

        public ActionResult TubaUsed()
        {
            ViewBag.PriceInfo = "$50 a month";
            return View("Tuba");
        }

        public ActionResult Trombone()
        {
            return View();
        }

        public ActionResult TromboneNew()
        {
            ViewBag.PriceInfo = "$60 a month";
            return View("Trombone");
        }

        public ActionResult TromboneUsed()
        {
            ViewBag.PriceInfo = "$35 a month";
            return View("Trombone");
        }

        public ActionResult Clarinet()
        {
            return View();
        }

        public ActionResult ClarinetNew()
        {
            ViewBag.PriceInfo = "$35 a month";
            return View("Clarinet");
        }

        public ActionResult ClarinetUsed()
        {
            ViewBag.PriceInfo = "$27 a month";
            return View("Clarinet");
        }

        public ActionResult Flute()
        {
            return View();
        }

        public ActionResult FluteNew()
        {
            ViewBag.PriceInfo = "$40 a month";
            return View("Flute");
        }

        public ActionResult FluteUsed()
        {
            ViewBag.PriceInfo = "$25 a month";
            return View("Flute");
        }

        public ActionResult Saxophone()
        {
            return View();
        }

        public ActionResult SaxophoneNew()
        {
            ViewBag.PriceInfo = "$42 a month";
            return View("Saxophone");
        }

        public ActionResult SaxophoneUsed()
        {
            ViewBag.PriceInfo = "$30 a month";
            return View("Saxophone");
        }
    }
}