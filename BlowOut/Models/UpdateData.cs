using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    public class UpdateData
    {
        
        public string clientFirstName { get; set; }
        public string clientLastName { get; set; }
        public string clientStreetAddress { get; set; }
        public string clientCity { get; set; }
        public string clientState { get; set; }
        public string clientZip { get; set; }
        public string clientEmail { get; set; }
        public string clientPhone { get; set; }
        public int instrumentID { get; set; }
        public string instrumentDesc { get; set; }
        public string instrumentType { get; set; }
        public float instrumentPrice { get; set; }
    }
}