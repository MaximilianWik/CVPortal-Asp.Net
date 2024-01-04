using CVPortalen.Models;
using Microsoft.AspNetCore.Mvc;

namespace CVPortalen.Controllers
{
    public class ProfilerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProfilFilip()
        {
            return View();
        }

        public IActionResult ProfilAnton()
        {
            return View();
        }

        public IActionResult ProfilMax()
        {
            return View();
        }
    }

    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            // Retrieve user profile information (you may replace this with your actual logic)
            var userProfile = GetCurrentUserProfile(); // Implement this method to get the user's profile

            if (userProfile != null)
            {
                return View(userProfile);
            }
            else
            {
                return NotFound();
            }
        }

        private Anvandare GetCurrentUserProfile()
        {
            // Implement this method to get the user's profile based on the currently logged-in user
            // You can use your DbContext or any other method to retrieve the user's profile
            // For simplicity, this example returns a hardcoded profile
            return new Anvandare
            {
            };


        }

    }
}
