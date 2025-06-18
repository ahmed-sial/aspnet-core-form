using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PracticeApplication.Models;

namespace PracticeApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string Index(PersonModel s)
        {
            return s.Name + "\n" + s.FatherName + "\n" + s.Gender + "\n" + s.CountryOfStay + "\n" + s.Age.ToString() + "\n" + s.IdentityNumber
                + "\n" + s.Dob + "\n" + s.IsMarried.ToString();
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
