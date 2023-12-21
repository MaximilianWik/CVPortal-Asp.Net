using CVPortalen.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CVPortalen.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<Anvandare> userManager;
        private readonly SignInManager<Anvandare> signInManager;

        public AccountController(UserManager<Anvandare> userMngr, SignInManager<Anvandare> signInMngr)
        {
            this.userManager = userMngr;
            this.signInManager = signInMngr;
        }

        //Vyn för användar registrering
        [HttpGet]
        public IActionResult Registrera()
        {
            return View();
        }

        [HttpGet]
        public IActionResult LogIn(string returnURL = "")
        {
            LoginViewModel loginViewModel = new LoginViewModel();
            return View(loginViewModel);
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
                    Console.WriteLine("Test");
                    await signInManager.SignInAsync(anvandare, isPersistent: true);
                    
                    return RedirectToAction("Index2", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(anvandarRegisterViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(
                    loginViewModel.AnvandarNamn,
                    loginViewModel.Losenord,
                    isPersistent: loginViewModel.rememberMe,
                    lockoutOnFailure: false);
                    
                if (result.Succeeded)
                {
                    return RedirectToAction("Index2", "Home");

                }
                else
                {
                    ModelState.AddModelError("", "Fel Användarnamn/Lösenord");
                }
            }
            return View(loginViewModel);
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
