using System.ComponentModel.DataAnnotations;

namespace CVPortalen.Models
{
    public class Message
    {
        public int Id { get; set; }

        [Required]
        public string SenderId { get; set; }

        [Required]
        public string ReceiverId { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime SentAt { get; set; }

        public bool IsRead { get; set; }

        // Lägg till detta till navigation property
        public Anvandare Sender { get; set; }
        public Anvandare Receiver { get; set; }
    }

}
