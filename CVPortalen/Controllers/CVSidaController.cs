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
        private readonly UserManager<Anvandare> _userManager;
        private readonly ProfilContext _context;

        public CVSidaController(ProfilContext context)
        {
            _context = context;
            this._userManager = _userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CVFilip()
        {
            return View();
        }
        public IActionResult CVAnton()
        {
            return View();
        }

        public  IActionResult CVMax()
        {
            return View();
        }

        public IActionResult CVStart() 
        {
            //var userID = _userManager.GetUserAsync(User).Result;
            
            //var userCVs = _context.cVs.Where(cv => cv.Anvandare == userID).ToList();

            return View(CVStart);
        }

        public IActionResult CVCreate(int cvId)
        {
            var cv = _context.cVs.Find(cvId);
            return View(cv);
        }

        [HttpPost]
        public IActionResult SaveCV(CV cv)
        {
            if (ModelState.IsValid)
            {
                if (cv.CVId == 0)
                {
                    // Nytt CV
                    _context.cVs.Add(cv);
                }
                else
                {
                    // Redigera befintligt CV
                    _context.Entry(cv).State = EntityState.Modified;
                }

                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("Edit", cv);
        }
    }
}

   

