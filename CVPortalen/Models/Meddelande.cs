using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CVPortalen.Models
{
    public class Meddelande
    {
        [Key]
        public int MeddelandeId { get; set; }

        public string MeddelandeText {  get; set; }

        [ForeignKey(nameof(Profil.ProfilId))]
        public int SkickatTill { get; set; }
    }
}
