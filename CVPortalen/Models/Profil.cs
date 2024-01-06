using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CVPortalen.Models
{
    public class Profil
    {
        internal int? profilid;

        [Key]
        public int ProfilId { get; set; } 

        public string Name { get; set; } 
        
        public string Adress { get; set; }
        
        public string AnvandarNamn { get; set; }

        public string Losenord { get; set; }

        public int TelefonNummer { get; set; }

        public string Epost { get; set; }

        public byte[] ProfilePicture { get; set; }

        public virtual Anvandare UserId { get; set; }

        

    }
}
