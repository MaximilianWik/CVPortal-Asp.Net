using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CVPortalen.Models
{
    public class Projekt
    {
        [Key]
        public int ProjektId { get; set; }
        public string ProjektName { get; set; }
        public int Artal { get; set; }
        public DateOnly Tid { get; set; }   
        public string Infromation { get; set; }

        [ForeignKey(nameof(Anvandare))]
        public string UserId { get; set; }
        public virtual Anvandare User { get; set; }

        // Navigeringsegenskap för deltagare
        public virtual ICollection<Anvandare> Deltagare { get; set; }


    }
}
