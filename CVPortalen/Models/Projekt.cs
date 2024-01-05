using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CVPortalen.Models
{
    public class Projekt
    {
        [Key]
        public int ProjektId { get; set; }
        [Required(ErrorMessage = "The ProjektName field is required.")]
        public string ProjektName { get; set; }

        [Required(ErrorMessage = "The Artal field is required.")]
        public int Artal { get; set; }
        public DateOnly Tid { get; set; }   
        public string Infromation { get; set; }

        [ForeignKey(nameof(UserId))]
        [Required(ErrorMessage = "The User field is required.")]
        public string UserId { get; set; }
        public virtual Anvandare User { get; set; }

        // Navigeringsegenskap för deltagare
        [Required(ErrorMessage = "The Deltagare field is required.")]
        public virtual ICollection<Anvandare> Deltagare { get; set; }


    }
}
