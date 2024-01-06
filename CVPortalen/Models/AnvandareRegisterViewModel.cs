using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CVPortalen.Models
{
    public class AnvandarRegisterViewModel
    {

        //[Required(ErrorMessage = "Vänligen skriv ett användarnamn")]
        //[StringLength(255)]
        //public string AnvandarNamn { get; set; }

        //[Required(ErrorMessage = "Vänligen skriv lösenord.")]
        //[DataType(DataType.Password)]
        //[Compare("BekraftaLosenord")]
        //public string Losenord { get; set; }

        //[Required(ErrorMessage = "Vänlingen bekräfta lösenordet")]
        //[DataType(DataType.Password)]
        //[Display(Name = "Bekrafta losenordet")]
        //public string BekraftaLosenord { get; set; }
        
            [Required(ErrorMessage = "Vänligen skriv ett användarnamn")]
            [StringLength(255)]
            public string AnvandarNamn { get; set; }

            [Required(ErrorMessage = "Vänligen skriv lösenord.")]
            [DataType(DataType.Password)]
            [Compare("BekraftaLosenord")]
            public string Losenord { get; set; }

            [Required(ErrorMessage = "Vänligen bekräfta lösenordet")]
            [DataType(DataType.Password)]
            [Display(Name = "Bekräfta lösenordet")]
            public string BekraftaLosenord { get; set; }

            //[Required(ErrorMessage = "Vänligen ange epostadress")]
            //[EmailAddress(ErrorMessage = "Ogiltig epostadress")]
            //public string Epost { get; set; }

            //[Required(ErrorMessage = "Vänligen ange telefonnummer")]
            //[RegularExpression(@"^[0-9]*$", ErrorMessage = "Ogiltigt telefonnummer")]
            //public string TelefonNummer { get; set; }

            //[Required(ErrorMessage = "Vänligen ange ditt namn")]
            //public string Namn { get; set; }

            [Display(Name = "Jag vill vara privat")]
            public bool VillVaraPrivat { get; set; }
        }

    }

