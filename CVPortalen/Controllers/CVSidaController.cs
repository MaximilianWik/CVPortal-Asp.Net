using System.Security.Claims;
using CVPortalen.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CVPortalen.Controllers
{
    public class CVSidaController : Controller
    {
        private readonly ProfilContext _context;

        public CVSidaController(ProfilContext context)
        {
            _context = context;
        }
        //public IActionResult SkapaCVSida()
        //{
        //    return View();
        //}

        public IActionResult SkapaCV()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SparaCV([FromBody] CV cv)
        {
            try
            {
                // Skapa ett nytt CV
                var newCV = new CV
                {
                    Titel = cv.Titel,
                    Arbetsplats = cv.Arbetsplats,
                    Beskrivning = cv.Beskrivning
                };

                // Lägg till det nya CV:et i kontexten och spara ändringar i databasen
                _context.cVs.Add(newCV);
                _context.SaveChanges();

                // Skicka det nya CV:et till SkapaCVSida för att visas
                return RedirectToAction("SkapaCVSida", new { cvId = newCV.CVId });
            }
            catch (Exception ex)
            {
                // Logga undantaget eller hantera det efter behov
                return BadRequest(new { success = false, message = ex.Message });
            }
        }

        public IActionResult SkapaCVSida(int? cvId)
        {
            // Hämta det nya CV:et från databasen baserat på cvId
            var newCV = _context.cVs.Find(cvId);

            // Skicka det nya CV:et till vyn
            return View(newCV);
        }
    }
}
