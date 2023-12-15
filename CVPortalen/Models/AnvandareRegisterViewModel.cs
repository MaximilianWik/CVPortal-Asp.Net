using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CVPortalen.Models
{
    public class AnvandarRegisterViewModel
    {

        [Required(ErrorMessage = "Vänligen skriv ett användarnamn din feta slyna.")]
        [StringLength(255)]
        public string AnvandarNamn { get; set; }

        [Required(ErrorMessage = "Vänligen skriv lösenord horunge.")]
        [DataType(DataType.Password)]
        [Compare("BekraftaLosenord")]
        public string Losenord { get; set; }

        [Required(ErrorMessage = "Vänlingen bekräfta lösenordet apjävel")]
        [DataType(DataType.Password)]
        [Display(Name = "Bekrafta losenordet")]
        public string BekraftaLosenord { get; set; }
    }
}
