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
        [HttpGet]
        public IActionResult Inbox()
        {
            // Hämta användarens ID
            var userId = userManager.GetUserId(User);

            // Hämta olästa meddelanden för användaren
            var unreadMessagesCount = dbContext.Messages
                .Where(m => m.ReceiverId == userId && !m.IsRead)
                .Count();

            // Sätt antalet olästa meddelanden i ViewBag för att användas i vyn
            ViewBag.UnreadMessagesCount = unreadMessagesCount;

            // Hämta användarens alla meddelanden
            var messages = dbContext.Messages
                .Where(m => m.ReceiverId == userId)
                .OrderByDescending(m => m.SentAt)
                .ToList();

            return View(messages);
        }

        [HttpPost]
        public IActionResult MarkAsRead(int messageId, bool isChecked)
        {
            try
            {
                // Hämta meddelandet från databasen baserat på messageId
                var message = dbContext.Messages.Find(messageId);

                if (message == null)
                {
                    // Meddelandet finns inte i databasen
                    return Json(new { success = false, error = "Message not found" });
                }

                // Uppdatera IsRead-egenskapen baserat på användarens val
                message.IsRead = isChecked;

                // Spara ändringarna i databasen
                dbContext.SaveChanges();

                // Hämta antalet olästa meddelanden för den inloggade användaren
                var userId = userManager.GetUserId(User);
                var unreadCount = dbContext.Messages.Count(m => m.ReceiverId == userId && !m.IsRead);

                // Returnera både resultatet av operationen och det uppdaterade antalet olästa meddelanden
                return Json(new { success = true, unreadCount = unreadCount });
            }
            catch (Exception ex)
            {
                // Något gick fel vid uppdatering av databasen
                return Json(new { success = false, error = ex.Message });
            }
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
            return View(viewModel);
        }

    }

}
