using CVPortalen.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Index()
        {
            // Hämtar och visar meddelanden för den inloggade användaren
            var userId = userManager.GetUserId(User);
            var messages = dbContext.Messages
                .Where(m => m.ReceiverId == userId)
                .OrderByDescending(m => m.SentAt)
                .ToList();

            return View(messages);
        }

        [HttpGet]
        public IActionResult Create()
        {
            // Display a form to create a new message
            return View();
        }

       

        [HttpPost]
        public async Task<IActionResult> CreateAsync(MessageViewModel model)
        {
            if (ModelState.IsValid)
            {
                var senderId = userManager.GetUserId(User);
                var receiver = await userManager.FindByIdAsync(model.ReceiverId);

                if (receiver != null)
                {
                    var message = new Message
                    {
                        SenderId = senderId,
                        ReceiverId = receiver.Id,
                        Content = model.Content,
                        SentAt = DateTime.UtcNow,
                        IsRead = false
                    };

                    dbContext.Messages.Add(message);
                    dbContext.SaveChanges();

                    
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("ReceiverId", "Receiver user not found");
                }
            }

            return View();  // returnerar viewen för att skicka meddelanden om d sker valideringsfel
        }





    }

}
