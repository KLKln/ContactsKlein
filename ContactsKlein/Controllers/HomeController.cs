using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactsKlein.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactsKlein.Controllers
{
    public class HomeController : Controller
    {
        private ContactContext context { get; set; }

        public HomeController(ContactContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var contacts = context.Contacts.OrderBy(c => c.LastName).ToList();
            return View(contacts);
        }
    }
}
