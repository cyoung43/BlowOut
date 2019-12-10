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
        public ActionResult UpdateData()
        {
            IEnumerable<ClientOrders> clientOrders =
                db.Database.SqlQuery<ClientOrders>(
                    "SELECT instrumentID, Description, type, price, clientID, " +
                        "firstName, lastName, address, city, state, zip, email, phone " +
                    "FROM client, instruments " +
                    "WHERE instruments.clientID = client.clientID " +
                    "ORDER BY instrumentID;"
                    );

            return View(clientOrders);
        }

        public ActionResult Delete(int? id)
        {
            
            Instrument instrument = db.Instruments.Find(id);

            int cID = instrument.ClientID;

            Client client = db.Clients.Find(cID);

            db.Database.ExecuteSqlCommand(
                "UPDATE Instruments " +
                "SET ClientID = null " +
                "WHERE InstrumentID = " + id + ";"
                );

            db.Clients.Remove(client);


            return View("UpdateData");
        }

    }
}