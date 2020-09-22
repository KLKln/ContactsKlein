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
        private ContactContext Context { get; set; }

        public HomeController(ContactContext ctx)
        {
            Context = ctx;
        }

        public IActionResult Index()
        {
            var contacts = Context.Contacts.OrderBy(c => c.LastName).ToList();
            return View(contacts);
        }
    }
}
