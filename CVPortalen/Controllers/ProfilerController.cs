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
        public IActionResult Create()
        {
            Profil Profiler = new Profil();
            return View(Profiler);
        }
        [HttpPost]
        public IActionResult Create(Profil Profiler)
        {
            {
                Console.WriteLine("Inside Create Profile POST method");

                if (!ModelState.IsValid)
                {
                    try
                    {
                        string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                        Console.WriteLine("Current UserId: " + currentUserId);

                        Anvandare currentUser = _context.Users.FirstOrDefault(u => u.Id == currentUserId);
                        Console.WriteLine("Current User: " + (currentUser != null ? currentUser.UserName : "null"));

                        if (currentUser != null)
                        {
                            Profiler.UserId = currentUserId; // Assign user ID directly to the Profile object

                            _context.Profils.Add(Profiler);
                            _context.SaveChanges();

                            Console.WriteLine("Profile saved successfully.");

                            // Redirect to a different action or view for profiles
                            return RedirectToAction("ProfileStart");
                        }
                    }
                    catch (Exception ex)
                    {
                        ModelState.AddModelError("", "An error occurred while creating the profile: " + ex.Message);
                        Console.WriteLine("Exception: " + ex.Message);
                    }
                }

                Console.WriteLine("ModelState is not valid or user is null.");

                return View(Profiler);
            }

        }
    }

   
}
