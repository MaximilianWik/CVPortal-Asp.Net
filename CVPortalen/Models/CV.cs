using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace CVPortalen.Models
{
    public class CV
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CVId { get; set; }
        [Required(ErrorMessage = "Skapare är obligatoriskt")]
        public string Skapare {  get; set; }
        [Required(ErrorMessage = "Utbildiningar är obligatoriskt")]
        public string Utbildningar {  get; set; }
        [Required(ErrorMessage = "Kompetenser är obligatoriskt")]

        public string Kompetenser { get; set; }
        [Required(ErrorMessage = "Erfarenheter är obligatoriskt")]
        public string TidigareErfarenheter { get; set; }

        [ForeignKey(nameof(Anvandare))]
        public string UserId { get; set; }
        public virtual Anvandare User { get; set; }
    }
}
