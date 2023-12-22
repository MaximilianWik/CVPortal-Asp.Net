using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace CVPortalen.Models
{
    public class CV
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CVId { get; set; }

        public string Titel {  get; set; }

        public string Arbetsplats { get; set; }

        public string Beskrivning { get; set; }

        [ForeignKey(nameof(Anvandare))]
        public string UserId { get; set; }

        public virtual Anvandare Anvandare { get; set; }
    }
}
