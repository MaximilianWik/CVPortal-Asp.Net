using System.ComponentModel.DataAnnotations;

namespace CVPortalen.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Hooooora")]
        [StringLength(100)]
        public string AnvandarNamn { get; set; }

        [Required(ErrorMessage = "DubbelHora")]
        [DataType(DataType.Password)]
        public string Losenord { get; set; }

        public bool rememberMe { get; set; }
    }
}
