using System.Linq;
using System.Security.Claims;
using CVPortalen.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CVPortalen.Controllers
{
    public class ProfilerController : Controller
    {
        private ProfilContext _context;

        public ProfilerController(ProfilContext context)
        {
            _context = context;
        }
        public IActionResult HemProfil()
        {
            List<Profil> AllaProfiler = _context.Profils.ToList();
            return View(AllaProfiler);

        }

        [HttpGet]
        public IActionResult CreateProfil()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProfil(Profil profil)
        {
            if (!ModelState.IsValid)
            {
                // Här kan du hämta användarinformationen från det autentiserade användaren
                var loggedInUserName = User.Identity.Name;
                var loggedInUser = _context.Users.SingleOrDefault(u => u.UserName == loggedInUserName);

                // Tilldela användarinformationen till Profil-objektet
                profil.AnvandarNamn = loggedInUserName;
                profil.UserId = loggedInUser;

                // Spara Profil-objektet i databasen
                _context.Profils.Add(profil);
                _context.SaveChanges();

                return RedirectToAction("Index", "Home"); // Du kan omdirigera till önskad vy efter att profilen har skapats
            }

            // Om modelltillståndet inte är giltigt, gå tillbaka till skapande av profilen med felmeddelanden
            return View(profil);
        }

        public IActionResult Visaprofil(int? id)
        {
            if (id == null)
            {
                // om ingen id skickas, gör något, t.ex. skicka till en felvy
                return View("error");
            }

            // hämta användarens profil från databasen baserat på id
            var profil = _context.Profils.FirstOrDefault(p => p.ProfilId == id);

            if (profil != null)
            {
                // om profilen hittades, skicka användaren till personligprofil-vyn med profilen
                return View("personligprofil", profil);
            }
            else
            {
                // om profilen inte hittades, gör något annat, t.ex. skicka till en felvy
                return View("error");

            }
        }

        [HttpGet]
        public IActionResult SökProfil()
        {
            var allProfiles = _context.Profils.ToList();
            return View(allProfiles);
        }
        [HttpPost]
        public IActionResult HemProfil(string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                // If search term is empty or null, show all profiles
                var allProfiles = _context.Profils.ToList();
                return View(allProfiles);
            }

            searchTerm = searchTerm.ToLower(); // Convert to lowercase for case-insensitive search

            var filteredProfiles = _context.Profils
                .Where(p => p.Name.ToLower().Contains(searchTerm))
                .ToList();

            return View(filteredProfiles);
        }
    }

   
}
