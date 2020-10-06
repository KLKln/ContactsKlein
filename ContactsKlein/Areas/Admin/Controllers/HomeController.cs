using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactsKlein.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactsKlein.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {        
        private ContactContext Context { get; set; }

        public HomeController(ContactContext ctx)
        {
            Context = ctx;
        }

        [Route("[area]/[controller]s/{id?}")]
        public IActionResult Index()
        {
            var contacts = Context.Contacts.OrderBy(c => c.LastName).ToList();
            return View(contacts);
        }
    }
}
