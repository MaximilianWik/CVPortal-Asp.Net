using System.ComponentModel.DataAnnotations;

namespace CVPortalen.Models
{
    public class MessageViewModel
    {
        [Required]
        public string ReceiverId { get; set; }

        [Required]
        public string Content { get; set; }
    }
    
}
