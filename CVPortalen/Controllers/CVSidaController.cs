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
            return View();
        }

        [HttpPost]
        public IActionResult Create(CV cv)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.cVs.Add(cv);
                    _context.SaveChanges();

                    return RedirectToAction("CVStart");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Ett fel inträffade vid skapandet av CV: " + ex.Message);
                }
            }

            return View(cv);
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

   

