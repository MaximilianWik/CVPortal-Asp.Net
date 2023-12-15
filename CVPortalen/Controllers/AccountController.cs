using CVPortalen.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CVPortalen.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<Anvandare> userManager;
        private SignInManager<Anvandare> signInManager;

        public AccountController(UserManager<Anvandare> userMngr, SignInManager<Anvandare> signInMngr)
        {
            this.userManager = userMngr;
            this.signInManager = signInMngr;
        }

        [HttpGet]
        public IActionResult LogIn(string returnURL = "")
        {
            LoginViewModel loginViewModel = new LoginViewModel();
            return View(loginViewModel);
        }


        //Vyn för användar registrering
        [HttpGet]
        public IActionResult Registrera()
        {
            return View();
        }


        //Registerar användare
        [HttpPost]
        public async Task<IActionResult> Registrera(AnvandarRegisterViewModel anvandarRegisterViewModel)
        {
            if (ModelState.IsValid)
            {
                Anvandare anvandare = new Anvandare();
                anvandare.UserName = anvandarRegisterViewModel.AnvandarNamn;

                var result = await userManager.CreateAsync(anvandare, anvandarRegisterViewModel.Losenord);

                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(anvandare, isPersistent: true);
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(anvandarRegisterViewModel);
        }

        //Logga ut användare
        [HttpPost]
        public async Task<IActionResult> Loggaut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}
