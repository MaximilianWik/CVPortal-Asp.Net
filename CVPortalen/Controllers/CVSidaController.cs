using Microsoft.AspNetCore.Mvc;

namespace CVPortalen.Controllers
{
    public class CVSidaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CVFilip()
        {
            return View();
        }
    }
}
