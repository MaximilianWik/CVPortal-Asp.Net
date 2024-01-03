using Microsoft.AspNetCore.Identity;

namespace CVPortalen.Models
{
    public class Anvandare:IdentityUser
    {
        // property för meddelanden
        public virtual ICollection<Message> SentMessages { get; set; }

        public static implicit operator string?(Anvandare? v)
        {
            throw new NotImplementedException();
        }
    }
}
