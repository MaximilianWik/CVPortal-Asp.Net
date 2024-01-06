using System.Linq;
using System.Security.Claims;
using CVPortalen.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CVPortalen.Controllers
{
    public class ProfilerController : Controller
    {
        private ProfilContext _context;
        private readonly ILogger<ProfilerController> _logger;

        public ProfilerController(ProfilContext context, ILogger<ProfilerController> logger)
        {
            _context = context;
            _logger = logger;
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
        public IActionResult CreateProfil(Profil profil, IFormFile profilePicture, bool isPrivate)
        {
            if (!ModelState.IsValid)
            {
                if (profilePicture != null && profilePicture.Length > 0)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        profilePicture.CopyTo(memoryStream);
                        profil.ProfilePicture = memoryStream.ToArray();
                    }
                }

                var loggedInUserName = User.Identity.Name;
                var loggedInUser = _context.Users.SingleOrDefault(u => u.UserName == loggedInUserName);

                profil.AnvandarNamn = loggedInUserName;
                profil.UserId = loggedInUser?.Id; // Använd användarens ID direkt som int

                profil.IsPrivate = isPrivate;

                _context.Profils.Add(profil);
                _context.SaveChanges();

                return RedirectToAction("Index", "Home");
            }

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
        public IActionResult HoppaTillProfil(string userName)
        {
            try
            {
                // Hämta användarens profil baserat på användarnamn
                var userProfile = _context.Profils.FirstOrDefault(p => p.AnvandarNamn == userName);

                if (userProfile == null)
                {
                    // Om profilen inte hittas, gör något, t.ex. skicka till en felvy
                    return View("error");
                }

                // Skicka användaren till personligprofil-vyn med den hämtade profilen
                return RedirectToAction("Visaprofil", new { id = userProfile.ProfilId });
            }
            catch (Exception ex)
            {
                // Logga eller skriv ut felmeddelandet för att felsöka
                Console.WriteLine($"Error in HoppaTillProfil: {ex.Message}");
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
        private bool ProfileExists(int id)
        {
            return _context.Profils.Any(e => e.ProfilId == id);
        }


        [HttpGet]
        public IActionResult EditProfil(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var existingProfile = _context.Profils.FirstOrDefault(p => p.ProfilId == id);

            if (existingProfile == null)
            {
                return NotFound();
            }

            return View(existingProfile);
        }

        [HttpPost]
        public IActionResult EditProfil(int id, [Bind("ProfilId,Name,Adress,TelefonNummer,IsPrivate, Epost")] Profil editedProfile, IFormFile newProfilePicture)
        {
            if (id != editedProfile.ProfilId)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                try
                {
                    // Retrieve the existing profile data from the data store based on the provided id
                    var existingProfile = _context.Profils.FirstOrDefault(p => p.ProfilId == id);

                    if (existingProfile == null)
                    {
                       
                        return NotFound();
                    }

                    

                    // Handle profile picture update
                    if (newProfilePicture != null && newProfilePicture.Length > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            newProfilePicture.CopyTo(memoryStream);
                            existingProfile.ProfilePicture = memoryStream.ToArray();
                        }
                    }

                    // Update other profile details
                    existingProfile.Name = editedProfile.Name;
                    existingProfile.Adress = editedProfile.Adress;
                    existingProfile.TelefonNummer = editedProfile.TelefonNummer;
                    existingProfile.IsPrivate = editedProfile.IsPrivate;
                    existingProfile.Epost = editedProfile.Epost;
                    _context.Profils.Update(existingProfile);

                    _context.SaveChanges();

                    return RedirectToAction("Visaprofil", new { id = editedProfile.ProfilId });
                }
                catch (Exception ex)
                {
                    
                    return View("error");
                }
            }

            // If model state is not valid, return to the edit view with the profile details
            return View(editedProfile);
        }

      




    }



}
