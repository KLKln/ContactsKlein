using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactsKlein.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

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

        public IActionResult About()
        {
            return Content("Home controller, About action");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult DummyPage1()
        {
            return View();
        }

        public IActionResult DummyPage2()
        {
            return View();
        }

        public IActionResult DummyPage3()
        {
            return View();
        }

        public IActionResult Admin()
        {
            return View();
        }
    }
}
