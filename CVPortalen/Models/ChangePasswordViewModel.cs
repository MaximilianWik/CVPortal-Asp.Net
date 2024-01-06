using System.ComponentModel.DataAnnotations;

namespace CVPortalen.Models
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "Vänligen ange ditt nuvarande lösenord.")]
        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; }

        [Required(ErrorMessage = "Vänligen ange ditt nya lösenord.")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Vänligen bekräfta ditt nya lösenord.")]
        [DataType(DataType.Password)]
        [Compare("NewPassword", ErrorMessage = "De nya lösenorden matchar inte.")]
        public string ConfirmNewPassword { get; set; }
    }
}
