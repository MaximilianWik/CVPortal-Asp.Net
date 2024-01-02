using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace CVPortalen.Models
{
    public class CV
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CVId { get; set; }
        [Required(ErrorMessage = "Titel är obligatoriskt")]
        public string Titel {  get; set; }
        [Required(ErrorMessage = "Arbetsplats är obligatoriskt")]
        public string Arbetsplats { get; set; }
        [Required(ErrorMessage = "Beskrivning är obligatoriskt")]
        public string Beskrivning { get; set; }

        [ForeignKey(nameof(Anvandare))]
        public virtual Anvandare user { get; set; }
    }
}
