using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Framework.Logging;

namespace TestNext.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var loggerFactory = new LoggerFactory().AddConsole();
            var logger = loggerFactory.CreateLogger(typeof(HomeController).FullName);

            logger.LogInformation("Test logging info");

            try {
                throw new InvalidOperationException("What do you do?..");
            }
            catch (Exception ex) {

                logger.LogError("Bad", ex);
            }
            ViewBag.Link = Url.Link("books", new { author = "Leo Tolstoy" });
            return View();
        }

        [Route("api/authors/{author}", Name = "books" )]
        public IEnumerable<string> GetBooks(string author) {
            return new List<string>() {
                "War and piece by " +  author
            };

        }

        public IActionResult About()
        {
            throw new InvalidOperationException("That is a secret");
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
