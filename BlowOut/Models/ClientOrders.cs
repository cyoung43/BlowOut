using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    public class ClientOrders
    {
        [Key]
        public int instrumentID { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public int clientID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
    }
}