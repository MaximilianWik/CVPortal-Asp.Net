using System.ComponentModel.DataAnnotations;

namespace CVPortalen.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Vänligen skriv in ett Användarnamn")]
        [StringLength(100)]
        public string AnvandarNamn { get; set; }

        [Required(ErrorMessage = "Vänligen Skriv in ett giltigt Lösenord")]
        [DataType(DataType.Password)]
        public string Losenord { get; set; }

        public bool rememberMe { get; set; }
    }
}
