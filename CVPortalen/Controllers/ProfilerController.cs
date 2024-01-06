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
        public IActionResult CreateProfil(Profil profil, IFormFile profilePicture)
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
        public IActionResult EditProfil(int id, [Bind("ProfilId,Name,Adress,TelefonNummer")] Profil editedProfile, IFormFile newProfilePicture)
        {
            if (id != editedProfile.ProfilId)
            {
                return NotFound();
            }

            // Check if the logged-in user is the owner of the profile
            //if (User.Identity.Name != editedProfile.AnvandarNamn)
            //{
            //    // If not the owner, return to an error view or handle it accordingly
            //    return View("error");
            //}

            if (!ModelState.IsValid)
            {
                try
                {
                    // Retrieve the existing profile data from the data store based on the provided id
                    var existingProfile = _context.Profils.FirstOrDefault(p => p.ProfilId == id);

                    if (existingProfile == null)
                    {
                        _logger.LogWarning($"Profile with ID {id} not found.");
                        return NotFound();
                    }

                    // Log information for debugging
                    _logger.LogInformation($"Edited Profile ID: {editedProfile.ProfilId}");
                    _logger.LogInformation($"Existing Profile ID: {existingProfile.ProfilId}");

                    // Handle profile picture update
                    if (newProfilePicture != null && newProfilePicture.Length > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            newProfilePicture.CopyTo(memoryStream);
                            editedProfile.ProfilePicture = memoryStream.ToArray();
                        }
                    }

                    // Update other profile details
                    //_context.Entry(existingProfile).CurrentValues.SetValues(editedProfile);
                    existingProfile.Name = editedProfile.Name;
                    existingProfile.Adress = editedProfile.Adress;
                    existingProfile.TelefonNummer = editedProfile.TelefonNummer;
                    //existingProfile.Epost = editedProfile.Epost;

                    _context.SaveChanges();

                    return RedirectToAction("Visaprofil", new { id = editedProfile.ProfilId });
                }
                catch (Exception ex)
                {
                    _logger.LogError($"Error updating profile with ID {id}: {ex.Message}");
                    return View("error");
                }
            }

            // If model state is not valid, return to the edit view with the profile details
            return View(editedProfile);
        }


        



    }



}
