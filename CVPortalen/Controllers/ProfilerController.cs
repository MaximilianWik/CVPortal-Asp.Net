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

        public IActionResult VisaProfil(int? id)
        {
            if (id == null)
            {
                // Om ingen id skickas, gör något, t.ex. skicka till en felvy
                return View("Error");
            }

            // Hämta användarens profil från databasen baserat på id
            var profil = _context.Profils.FirstOrDefault(p => p.ProfilId == id);

            if (profil != null)
            {
                // Om profilen hittades, skicka användaren till PersonligProfil-vyn med profilen
                return View("PersonligProfil", profil);
            }
            else
            {
                // Om profilen inte hittades, gör något annat, t.ex. skicka till en felvy
                return View("Error");
            }
        }


        //[HttpGet]
        //public IActionResult Create()
        //{
        //    Profil Profiler = new Profil();
        //    return View(Profiler);
        //}
        //[HttpPost]
        //public IActionResult Create(Profil Profiler)
        //{
        //    {
        //        Console.WriteLine("Inside Create Profile POST method");

        //        if (!ModelState.IsValid)
        //        {
        //            try
        //            {
        //                string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        //                Console.WriteLine("Current UserId: " + currentUserId);

        //                Anvandare currentUser = _context.Users.FirstOrDefault(u => u.Id == currentUserId);
        //                Console.WriteLine("Current User: " + (currentUser != null ? currentUser.UserName : "null"));

        //                if (currentUser != null)
        //                {
        //                    Profiler.UserId = currentUserId; // Assign user ID directly to the Profile object

        //                    _context.Profils.Add(Profiler);
        //                    _context.SaveChanges();

        //                    Console.WriteLine("Profile saved successfully.");

        //                    // Redirect to a different action or view for profiles
        //                    return RedirectToAction("ProfileStart");
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                ModelState.AddModelError("", "An error occurred while creating the profile: " + ex.Message);
        //                Console.WriteLine("Exception: " + ex.Message);
        //            }
        //        }

        //        Console.WriteLine("ModelState is not valid or user is null.");

        //        return View(Profiler);
        //    }

        //}
    }

   
}
