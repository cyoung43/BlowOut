using BlowOut.DAL;
using BlowOut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class OrdersController : Controller
    {
        private RentalsContext db = new RentalsContext();
        
        // GET: Orders
        [Authorize]
        public ActionResult UpdateData()
        {
            IEnumerable<ClientOrders> clientOrders =
                db.Database.SqlQuery<ClientOrders>(
                    "SELECT instrumentID, Description, type, price, " +
                        "firstName, lastName, address, city, state, zip, email, phone " +
                    "FROM instruments LEFT JOIN client ON client.clientID = instruments.clientID " +                    
                    "ORDER BY instrumentID;"
                    );

            return View(clientOrders);
        }

        public ActionResult Delete(int? id)
        {
            
            Instrument instrument = db.Instruments.Find(id);

            int? cID = instrument.ClientID;                      

            db.Database.ExecuteSqlCommand(
                "UPDATE Instruments " +
                "SET ClientID = null " +
                "WHERE InstrumentID = " + id + ";"
                );

            return RedirectToAction("Delete", "Clients", new { id = cID});
        }

    }
}