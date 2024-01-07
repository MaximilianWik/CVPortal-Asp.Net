using System.ComponentModel.DataAnnotations;

namespace CVPortalen.Models
{
    public class Message
    {
        public int Id { get; set; }

        [Required]
        public string? SenderId { get; set; }

        [Required]
        public string ReceiverId { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime SentAt { get; set; }

        public bool IsRead { get; set; }

        // Lägg till detta till navigation property
        public virtual Anvandare Sender { get; set; }
        public virtual Anvandare Receiver { get; set; }
    }

}
