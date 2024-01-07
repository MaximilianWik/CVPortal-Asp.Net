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
                string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                // Hämta och ta bort markerade CV-objekt från databasen som tillhör den inloggade användaren
                var selectedCVs = _context.cVs.Where(cv => cvIds.Contains(cv.CVId) && cv.UserId == currentUserId).ToList();

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
        public IActionResult ZlatanCV()
        {
            return View();
        }
        public IActionResult GatesCV()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EditCV(int id)
        {
            var cv = _context.cVs.FirstOrDefault(c => c.CVId == id);

            if (cv != null && cv.Skapare == User.FindFirstValue(ClaimTypes.NameIdentifier))
            {
                // Användaren är skaparen av CV:t, och det är tillåtet att redigera
                return View(new CV());
            }
            else
            {
                // Användaren har inte behörighet att redigera detta CV
                return RedirectToAction("EditCV");
            }
        }


        [HttpPost]
        public IActionResult EditCV(int id, [Bind("CVId, Skapare, TidigareErfarenheter, Utbildningar, Kompetenser")] CV editedCV)
        {
            if (id != editedCV.CVId)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                try
                {
                    // Hämta befintlig CV-data från databasen baserat på det angivna id:et
                    var existingCV = _context.cVs.FirstOrDefault(cv => cv.CVId == id);

                    if (existingCV == null)
                    {
                        return NotFound();
                    }

                    // Uppdatera andra detaljer i CV:et
                    existingCV.Skapare = editedCV.Skapare;
                    existingCV.TidigareErfarenheter = editedCV.TidigareErfarenheter;
                    existingCV.Utbildningar = editedCV.Utbildningar;
                    existingCV.Kompetenser = editedCV.Kompetenser;

                    _context.cVs.Update(existingCV);
                    _context.SaveChanges();

                    return RedirectToAction("EditCV", new { id = editedCV.CVId });
                }
                catch (Exception ex)
                {
                    return View("error");
                }
            }

            // Om modelltillståndet inte är giltigt, återgå till redigeringsvyn med CV-detaljerna
            return View(editedCV);
        }

    }

}


   

