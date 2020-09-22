using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsKlein.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        [Required(ErrorMessage = "Please enter a last name.")]
        public String LastName {get; set;}
        [Required(ErrorMessage = "Please enter a first name.")]
        public String FirstName { get; set; }
        [Required(ErrorMessage = "Please enter a phone number.")]
        public String PhoneNumber { get; set; }
        public String Address { get; set; }
        public String Note { get; set; }

    }
}
