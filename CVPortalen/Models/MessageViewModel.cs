using System.ComponentModel.DataAnnotations;

namespace CVPortalen.Models
{
    public class MessageViewModel
    {
        [Required]
        public string ReceiverId { get; set; }

        [Required]
        public string Content { get; set; }

        public string SenderId { get; set; }
        public string SenderName { get; set; }

        public string ReceiverUserName { get; set; }
        public string ReceiverName { get; set; }


    }
    
}
