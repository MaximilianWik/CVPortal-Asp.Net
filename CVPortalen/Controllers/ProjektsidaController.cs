using CVPortalen.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CVPortalen.Controllers
{
    public class ProjektsidaController : Controller
    {

        private readonly ProfilContext _context;

        public ProjektsidaController(ProfilContext context)
        {
            _context = context;
        }

        public IActionResult ProjektStart()
        {
            List<Projekt> allProjects = _context.projekt.ToList();
            return View(allProjects);
        }

        [HttpGet]
        public IActionResult CreateProjekt()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProjekt(Projekt project)
        {
            if (!ModelState.IsValid)
            {
                try
                {
                    string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    Anvandare currentUser = _context.Users.FirstOrDefault(u => u.Id == currentUserId);

                    if (currentUser != null)
                    {
                        project.UserId = currentUserId;
                        _context.projekt.Add(project);
                        _context.SaveChanges();

                        return RedirectToAction("ProjektStart");
                    }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Ett fel inträffade vid skapandet av projekt: " + ex.Message);
                }
            }

            return View(project);
        }


        [HttpPost]
        public IActionResult JoinProjekt(int projectId)
        {
            try
            {
                // Hämta användarens ID från Identity
                string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                // Hämta projektet från databasen inklusive deltagarlistan
                var project = _context.projekt.Include(p => p.User).Include(p => p.Deltagare).FirstOrDefault(p => p.ProjektId == projectId);

                if (project != null && currentUserId != null)
                {
                    // Kolla om användaren redan är med i projektet
                    if (!project.Deltagare.Any(d => d.Id == currentUserId))
                    {
                        // Lägg till användaren i deltagarlistan för projektet
                        project.Deltagare.Add(_context.Users.Find(currentUserId));
                        _context.SaveChanges();

                        return Json(new { success = true, message = "Du har gått med i projektet!", username = User.Identity.Name });
                    }
                    else
                    {
                        return Json(new { success = false, message = "Du är redan med i projektet!" });
                    }
                }
                else
                {
                    return Json(new { success = false, message = "Projektet hittades inte!" });
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "Ett fel uppstod: " + ex.Message });
            }
        }

        
        public IActionResult ProjektDetails(int id)
        {
            var project = _context.projekt.Include(p => p.User).FirstOrDefault(p => p.ProjektId == id);
            return View(project);
        }

        [HttpPost]
        public IActionResult LeaveProject(int projectId)
        {
            try
            {
                string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var project = _context.projekt
                    .Include(p => p.Deltagare)
                    .FirstOrDefault(p => p.ProjektId == projectId);

                if (project != null && currentUserId != null)
                {
                    var userToRemove = project.Deltagare.FirstOrDefault(d => d.Id == currentUserId);

                    if (userToRemove != null)
                    {
                        project.Deltagare.Remove(userToRemove);
                        _context.SaveChanges();
                    }
                }

                // Returnera deltagarna som en JSON-respons
                var projectDeltagare = project.Deltagare.Select(d => d.UserName).ToList();

                return Json(new { success = true, message = "Du har lämnat projektet!", deltagare = projectDeltagare });
            }
            catch (Exception ex)
            {
                // Handle exceptions as needed
                return Json(new { success = false, message = "Ett fel uppstod: " + ex.Message });
            }
        }









    }
}
