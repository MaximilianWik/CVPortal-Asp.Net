using Microsoft.AspNetCore.Identity;

namespace CVPortalen.Models
{
    public class Anvandare:IdentityUser
    {
        // property för meddelanden
        public ICollection<Message> SentMessages { get; set; }
    }
}
