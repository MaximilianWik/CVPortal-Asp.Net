using System.Diagnostics;
using CVPortalen.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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


        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                // Hämta användarens ID
                var userId = _userManager.GetUserId(User);

                // Hämta olästa meddelanden för användaren
                var unreadMessagesCount = _dBContext.Messages
                    .Where(m => m.ReceiverId == userId && !m.IsRead)
                    .Count();

                // Sätt antalet olästa meddelanden i ViewBag för att användas i vyn
                ViewBag.UnreadMessagesCount = unreadMessagesCount;
            }
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

    }
}
