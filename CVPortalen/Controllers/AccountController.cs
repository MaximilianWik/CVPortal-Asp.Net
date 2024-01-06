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

        //Vanvändar registrering
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

                    // Logga in användaren
                    await signInManager.SignInAsync(anvandare, isPersistent: true);

                    // Utför din egen omdirigering till CreateProfil
                    return RedirectToAction("CreateProfil", "Profiler");
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


        //[HttpPost]
        //public async Task<IActionResult> Registrera(AnvandarRegisterViewModel anvandarRegisterViewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Anvandare anvandare = new Anvandare();
        //        anvandare.UserName = anvandarRegisterViewModel.AnvandarNamn;

        //        var result = await userManager.CreateAsync(anvandare, anvandarRegisterViewModel.Losenord);


        //        if (result.Succeeded)
        //        {
        //            Console.WriteLine("Test");
        //            await signInManager.SignInAsync(anvandare, isPersistent: true);

        //            return RedirectToAction("CreateProfil");
        //        }
        //        else
        //        {
        //            foreach (var error in result.Errors)
        //            {
        //                ModelState.AddModelError("", error.Description);
        //            }
        //        }
        //    }
        //    return View(anvandarRegisterViewModel);
        //}

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
                    return RedirectToAction("Index", "Home");

                }
                else
                {
                    ModelState.AddModelError("", "Fel Användarnamn/Lösenord");
                }
            }
            return View(loginViewModel);
        }

        //Logga ut användare

        public async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        //[HttpPost]
        //public async Task<IActionResult> Loggaut()
        //{
        //    await signInManager.SignOutAsync();
        //    return RedirectToAction("Index", "Home");
        //}


        //Ändra pass
        [HttpGet]
        public IActionResult ChangePassword(string id)
        {
            // hämtar user baserad på id parameter
            var user = userManager.FindByNameAsync(id).Result;

            if (user != null)
            {
                // Logik för att hantera user ID
                var userId = user.Id;

                

                // Returnerar vyn ChangePasswordViewModel
                return View(new ChangePasswordViewModel());
            }
            else
            {
                // ifall user is inte hittas
               
                return RedirectToAction("UserNotFound", "Error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByNameAsync(User.Identity.Name);
                if (user != null)
                {
                    var result = await userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);

                    if (result.Succeeded)
                    {
                        
                        await signInManager.SignInAsync(user, isPersistent: false);
                        return RedirectToAction("Index", "Home"); // Redirect to the home page or profile page
                    }

                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Användaren hittades inte.");
                }
            }

            return View(model);
        }


    }

        
}
    