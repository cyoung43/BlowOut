using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlowOut.Models;
using System.Data.Entity;
using BlowOut.DAL;

namespace BlowOut.Controllers
{

    public class InstrumentController : Controller
    {
        private RentalsContext db = new RentalsContext();

        // GET: Instrument
        public ActionResult Trumpet()
        {

            return View();
        }

        public ActionResult NewTrumpet()
        {

            //get new pictures
            //set up instrument in database
            var entity = new Instrument { Description = "Trumpet", PicURL = "~/Content/Images/trumpet2.jpg", Price = 55, Type = "New" };
            db.Instruments.Add(entity);
            db.SaveChanges();

            //go to client method
            return RedirectToAction("Create", "Clients");
        }

        public ActionResult UsedTrumpet()
        {
            //set up instrument in database
            var entity = new Instrument { Description = "Trumpet", PicURL = "~/Content/Images/trumpet2.jpg", Price = 25, Type = "Used" };
            db.Instruments.Add(entity);
            db.SaveChanges();

            //go to client method
            return RedirectToAction("Create", "Clients");
        }

        public ActionResult Tuba()
        {
            return View();
        }

        public ActionResult TubaNew()
        {
            //set up instrument in database
            var entity = new Instrument { Description = "Tuba", PicURL = "~/Content/Images/tuba3.jpg", Price = 70, Type = "New" };
            db.Instruments.Add(entity);
            db.SaveChanges();

            //go to client method
            return RedirectToAction("Create", "Clients");
        }

        public ActionResult TubaUsed()
        {
            //set up instrument in database
            var entity = new Instrument { Description = "Tuba", PicURL = "~/Content/Images/tuba3.jpg", Price = 50, Type = "Used" };
            db.Instruments.Add(entity);
            db.SaveChanges();

            //go to client method
            return RedirectToAction("Create", "Clients");
        }

        public ActionResult Trombone()
        {
            return View();
        }

        public ActionResult TromboneNew()
        {
            //set up instrument in database
            var entity = new Instrument { Description = "Trombone", PicURL = "~/Content/Images/trombone3.jpg", Price = 60, Type = "New" };
            db.Instruments.Add(entity);
            db.SaveChanges();

            //go to client method
            return RedirectToAction("Create", "Clients");
        }

        public ActionResult TromboneUsed()
        {
            //set up instrument in database
            var entity = new Instrument { Description = "Trombone", PicURL = "~/Content/Images/trombone3.jpg", Price = 35, Type = "Used" };
            db.Instruments.Add(entity);
            db.SaveChanges();

            //go to client method
            return RedirectToAction("Create", "Clients");
        }

        public ActionResult Clarinet()
        {
            return View();
        }

        public ActionResult ClarinetNew()
        {
            //set up instrument in database
            var entity = new Instrument { Description = "Clarinet", PicURL = "~/Content/Images/clarinet2.jpg", Price = 35, Type = "New" };
            db.Instruments.Add(entity);
            db.SaveChanges();

            //go to client method
            return RedirectToAction("Create", "Clients");
        }

        public ActionResult ClarinetUsed()
        {
            //set up instrument in database
            var entity = new Instrument { Description = "Clarinet", PicURL = "~/Content/Images/clarinet2.jpg", Price = 27, Type = "Used" };
            db.Instruments.Add(entity);
            db.SaveChanges();

            //go to client method
            return RedirectToAction("Create", "Clients");
        }

        public ActionResult Flute()
        {
            return View();
        }

        public ActionResult FluteNew()
        {
            //set up instrument in database
            var entity = new Instrument { Description = "Flute", PicURL = "~/Content/Images/flute2.jpg", Price = 40, Type = "New" };
            db.Instruments.Add(entity);
            db.SaveChanges();

            //go to client method
            return RedirectToAction("Create", "Clients");
        }

        public ActionResult FluteUsed()
        {
            //set up instrument in database
            var entity = new Instrument { Description = "Flute", PicURL = "~/Content/Images/flute2.jpg", Price = 25, Type = "Used" };
            db.Instruments.Add(entity);
            db.SaveChanges();

            //go to client method
            return RedirectToAction("Create", "Clients");
        }

        public ActionResult Saxophone()
        {
            return View();
        }

        public ActionResult SaxophoneNew()
        {
            //set up instrument in database
            var entity = new Instrument { Description = "Saxophone", PicURL = "~/Content/Images/saxophone2.jpg", Price = 42, Type = "New" };
            db.Instruments.Add(entity);
            db.SaveChanges();

            //go to client method
            return RedirectToAction("Create", "Clients");
        }

        public ActionResult SaxophoneUsed()
        {
            //set up instrument in database
            var entity = new Instrument { Description = "Saxophone", PicURL = "~/Content/Images/saxophone2.jpg", Price = 30, Type = "Used" };
            db.Instruments.Add(entity);
            db.SaveChanges();

            //go to client method
            return RedirectToAction("Create", "Clients");
        }
    }
}