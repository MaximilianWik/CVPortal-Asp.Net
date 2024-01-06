using AspNetCore;
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

        [HttpPost]
        public async Task<IActionResult> Loggaut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        //[HttpPost]
        //public async Task<IActionResult> ChangePassword(Views_Profiler_PersonligProfil model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(model);
        //    }

        //    var user = await userManager.GetUserAsync(User);

        //    if (user == null)
        //    {
        //        return NotFound($"Unable to load user with ID '{userManager.GetUserId(User)}'.");
        //    }

        //    var changePasswordResult = await userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);

        //    if (!changePasswordResult.Succeeded)
        //    {
        //        foreach (var error in changePasswordResult.Errors)
        //        {
        //            ModelState.AddModelError(string.Empty, error.Description);
        //        }
        //        return View(model);
        //    }

        //    await signInManager.RefreshSignInAsync(user);
        //    return RedirectToAction("Index", new { Message = "Ditt lösenord har ändrats." });
        //}


       


    }
}
    