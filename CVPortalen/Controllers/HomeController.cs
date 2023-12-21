using System.Diagnostics;
using CVPortalen.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CVPortalen.Controllers
{
    public class HomeController : Controller
    {
        private ProfilContext _dBContext;

        public HomeController(ProfilContext dbContext)
        {
            _dBContext = dbContext;
        }


        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}


        //Bara authorizeacde användare kan se viewen nedanför

        //[Authorize]

        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult Index2()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ProfilFilip()
        {
            return View();
        }

        public IActionResult ProjektJacob()
        {
            return View();
        }

        //Nedan kan behöva av-kommenteras vid senare tillfälle
        public IActionResult Privacy()
        {
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
