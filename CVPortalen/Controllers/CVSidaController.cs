using System.Security.Claims;
using CVPortalen.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CVPortalen.Controllers
{
    //[Authorize]
    public class CVSidaController : Controller
    {

        private ProfilContext _context;

        public CVSidaController(ProfilContext context)
        {
            _context = context;
        }

        public IActionResult CVStart()
        {
            List<CV> allCVs = _context.cVs.ToList();
            return View(allCVs);
        }


        // Visa formulär för att skapa nytt CV
        [HttpGet]
        public IActionResult Create()
        {
            CV cV = new CV();
            return View(cV);
        }

        [HttpPost]
        public IActionResult Create(CV cV)
        {
            Console.WriteLine("Inside Create POST method");

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
                        cV.UserId = currentUserId; // Tilldela användar-ID direkt till CV-objektet

                        _context.cVs.Add(cV);
                        _context.SaveChanges();

                        Console.WriteLine("CV saved successfully.");

                        return RedirectToAction("CVStart");
                    }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Ett fel inträffade vid skapandet av CV: " + ex.Message);
                    Console.WriteLine("Exception: " + ex.Message);
                }
            }

            Console.WriteLine("ModelState is not valid or user is null.");

            return View(cV);
        }






        [HttpPost]
        public IActionResult DeleteSelectedCVs(List<int> cvIds)
        {
            try
            {
                // Hämta och ta bort markerade CV-objekt från databasen
                var selectedCVs = _context.cVs.Where(cv => cvIds.Contains(cv.CVId)).ToList();
                _context.cVs.RemoveRange(selectedCVs);
                _context.SaveChanges();

                return Json(new { success = true, message = "CV-objekt borttagna framgångsrikt." });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "Ett fel uppstod vid borttagning av CV-objekt: " + ex.Message });
            }
        }

        public IActionResult Details(int id)
        {
            var cv = _context.cVs.FirstOrDefault(c => c.CVId == id);
            return View(cv);
        }
    }
}

   

