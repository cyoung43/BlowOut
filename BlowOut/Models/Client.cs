using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    [Table("Client")]
    public class Client
    {
        [Key]
        public int ClientID { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        [DisplayName("First Name")]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        [DisplayName("Last Name")]
        [StringLength(20)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your address")]
        [DisplayName("Home Address")]
        [StringLength(20)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter your city")]
        [DisplayName("City")]
        [StringLength(15)]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter your state")]
        [DisplayName("State Abbreviation")]
        [StringLength(2)]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter your zip code")]
        [DisplayName("Zip Code")]
        [RegularExpression(@"^\d{5}([\-]\d{4})?$", ErrorMessage = "Please enter zip in xxxxx format.")]
        [StringLength(5, MinimumLength = 5)]
        public string Zip { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        [DisplayName("Email Address")]
        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone")]
        [DisplayName("Phone Number")]
        [StringLength(12)]
        [Phone]
        [RegularExpression(@"^(\([0 - 9]{3}\)|[0-9]{3}-)[0-9]{3}-[0-9]{4}|(\([0 - 9]{3}\)|[0-9]{3})[0-9]{3}[0-9]{4}$", ErrorMessage = "Please enter your phone in (xxx) xxx-xxxx format")]
        public string Phone { get; set; }
    }
}