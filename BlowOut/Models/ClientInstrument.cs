using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    public class ClientInstrument
    {
        [Key]
        public int ClientID { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public string PicURL { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}