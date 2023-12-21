using System.Diagnostics;
using CVPortalen.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CVPortalen.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProfilContext _dBContext;
        private readonly UserManager<Anvandare> _userManager;

        public HomeController(ProfilContext dbContext, UserManager<Anvandare> userManager)
        {
            _dBContext = dbContext;
            _userManager = userManager;
        }




        //[Authorize]
        public IActionResult Index()
        {
            var currentUser = _userManager.GetUserAsync(User).Result;

            // Fetch messages for the current user
            var messages = _dBContext.Messages
                .Where(m => m.ReceiverId == currentUser.Id)
                .ToList();

            return View(messages);
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
