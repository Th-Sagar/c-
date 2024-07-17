using Microsoft.AspNetCore.Mvc;

namespace Razor.Controllers
{
    public class UserMgmtController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        [ViewData]
        public string Title { get; set; }
        public IActionResult Register()
        {
            //ViewData["Greeting"] = "Hello";
            //Title="this is the register page";
            /* ViewData["Address"] = new Address()
             {
                 Name = "steve",
                 Street = "123 Main St",
                 City = "Anytown",
                 State = "TX",
                 PostalCode = "12345"
             };
            */


            /*
             ViewBag.Greeting = "Hello";
            ViewBag.Address = new Address()
            {
                Name = "steve",
                Street = "123 Main St",
                City = "Anytown",
                State = "TX",
                PostalCode = "12345"
            };

            */

            return View();
        }
    }
}
