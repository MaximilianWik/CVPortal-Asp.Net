using Microsoft.AspNetCore.Identity;

namespace CVPortalen.Models
{
    public class Anvandare:IdentityUser
    {
        //property för meddelanden
        public virtual ICollection<Message> SentMessages { get; set; }
        public virtual ICollection<Message> RecivedMessages { get; set; }

        public virtual CV CV { get; set; }

        public virtual ICollection<Projekt> projekt { get; set; }

        public virtual Profil Profil { get; set; }


        public static implicit operator string?(Anvandare? v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Anvandare(string v)
        {
            throw new NotImplementedException();
        }
    }
}
