using CVPortalen.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CVPortalen.Controllers
{
        public class MessageController : Controller
        {
            private readonly UserManager<Anvandare> userManager;
            private readonly ProfilContext dbContext;

            public MessageController(UserManager<Anvandare> userManager, ProfilContext dbContext)
            {
                this.userManager = userManager;
                this.dbContext = dbContext;
            }

            public IActionResult Inbox()
            {
                // Hämta användarens meddelanden
                var userId = userManager.GetUserId(User);
                var messages = dbContext.Messages
                    .Where(m => m.ReceiverId == userId)
                    .OrderByDescending(m => m.SentAt)
                    .ToList();

                return View(messages);
            }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult SkickaMeddelandeAsync(int profilId)
        {
            // Hämta mottagarens UserId baserat på profilId
            var receiverUserId = dbContext.Profils
                .Where(p => p.ProfilId == profilId)
                .Select(p => p.UserId)
                .FirstOrDefault();

            if (receiverUserId == null)
            {
                // Åtgärda det här på lämpligt sätt, kanske genom att visa ett felmeddelande eller omdirigera till en annan sida
                return NotFound();
            }

            var viewModel = new MessageViewModel
            {
                ReceiverId = receiverUserId,
            };

            // Kontrollera om användaren är inloggad innan du försöker hämta UserId
            if (User.Identity.IsAuthenticated)
            {
                // Hämta användarobjektet för den inloggade användaren
                var currentUser = userManager.GetUserAsync(HttpContext.User).Result;

                if (currentUser != null)
                {
                    viewModel.SenderId = currentUser.Id;
                }
                else
                {
                    // Åtgärda det här på lämpligt sätt om det inte finns en inloggad användare
                    return NotFound();
                }
            }

            return View(viewModel);
        }



        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> SkickaMeddelandeAsync(MessageViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                // Kontrollera om användaren är inloggad och använd formulärets avsändar-ID
                var senderId = viewModel.SenderId;

                if (User.Identity.IsAuthenticated)
                {
                    // Hämta användarobjektet för den inloggade användaren (om inloggad)
                    var currentUser = await userManager.GetUserAsync(HttpContext.User);

                    if (currentUser != null)
                    {
                        // Använd användarens ID som avsändar-ID om formuläret är tomt
                        senderId = string.IsNullOrWhiteSpace(senderId) ? currentUser.Id : senderId;

                        // Kontrollera om avsändar-ID är giltigt
                        var senderUser = await userManager.FindByIdAsync(senderId);
                        if (senderUser == null)
                        {
                            // Åtgärda det här på lämpligt sätt, kanske genom att visa ett felmeddelande eller omdirigera till en annan sida
                            return NotFound($"Användaren med ID {senderId} existerar inte.");
                        }
                    }
                }

                // Kontrollera om avsändar-ID är giltigt (för icke inloggade användare)
                if (!User.Identity.IsAuthenticated && string.IsNullOrWhiteSpace(senderId))
                {
                    // Åtgärda det här på lämpligt sätt, kanske genom att visa ett felmeddelande eller omdirigera till en annan sida
                    return NotFound("Ogiltigt avsändar-ID för icke inloggade användare.");
                }

                // Hämta användarobjektet för mottagaren baserat på ReceiverId
                var receiverUser = await userManager.FindByIdAsync(viewModel.ReceiverId.ToString());

                if (receiverUser == null)
                {
                    // Åtgärda det här på lämpligt sätt, kanske genom att visa ett felmeddelande eller omdirigera till en annan sida
                    return NotFound($"Användaren med ID {viewModel.ReceiverId} existerar inte.");
                }

                // Skapa ett nytt meddelandeobjekt baserat på ViewModel
                var message = new Message
                {
                    SenderId = senderId,
                    ReceiverId = receiverUser.Id,
                    Content = viewModel.Content,
                    SentAt = DateTime.Now,
                    IsRead = false
                };

                // Spara meddelandet i databasen
                dbContext.Messages.Add(message);
                dbContext.SaveChanges();

                // Återvänd till Inbox-åtgärden för att visa uppdaterad inkorg
                return RedirectToAction("Inbox");
            }

            // Om ModelState inte är giltig, återgå till samma vyn för att visa felmeddelanden
            return View(viewModel);
        }




















    }

}
