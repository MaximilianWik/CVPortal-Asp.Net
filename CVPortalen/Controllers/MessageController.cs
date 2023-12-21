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
            // Retrieve and display messages for the current user
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
        public IActionResult Create(MessageViewModel model)
        {
            // Create and send a new message
            if (ModelState.IsValid)
            {
                var senderId = userManager.GetUserId(User);

                var message = new Message
                {
                    SenderId = senderId,
                    ReceiverId = model.ReceiverId,
                    Content = model.Content,
                    SentAt = DateTime.UtcNow,
                    IsRead = false
                };


                dbContext.Messages.Add(message);
                dbContext.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(model);
        }
    }

}
