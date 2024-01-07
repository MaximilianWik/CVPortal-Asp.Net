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
                // H�mta anv�ndarens ID
                var userId = _userManager.GetUserId(User);

                // H�mta ol�sta meddelanden f�r anv�ndaren
                var unreadMessagesCount = _dBContext.Messages
                    .Where(m => m.ReceiverId == userId && !m.IsRead)
                    .Count();

                // S�tt antalet ol�sta meddelanden i ViewBag f�r att anv�ndas i vyn
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

        //Nedan kan beh�va av-kommenteras vid senare tillf�lle
        public IActionResult Privacy()
        {
            return View();
        }

    }
}
