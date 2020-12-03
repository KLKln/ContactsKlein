using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ContactsKlein.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        [Required(ErrorMessage = "Please enter a last name.")]
        [RegularExpression("^[a-zA-Z0-9]+$", ErrorMessage = "Name may not contain special characters")]
        public string LastName {get; set;}
        [Required(ErrorMessage = "Please enter a first name.")]
        [RegularExpression("^[a-zA-Z0-9]+$", ErrorMessage = "Name may not contain special characters")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter a phone number.")]
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }

    }
}
