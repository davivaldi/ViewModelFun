using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using viewmodelFun.Models;

namespace viewmodelFun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            Message newMessage = new Message()
            {
                text = "askjdkasdjkjasdjflkjadsflkjlsfdlkjljsdaflkjlasdjflkjasflkjadslk"

            };


            return View(newMessage);
        }

        [HttpGet]
        [Route("user")]
        public IActionResult Use()
        {
            User user = new User()
            {
                FirstName ="Diamond",
                LastName = "David Savage"
            };

            return View(user);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
