using System.ComponentModel.DataAnnotations;

namespace CVPortalen.Models
{
    public class Projekt
    {
        [Key]
        public int ProjektId { get; set; }
        public string ProjektName { get; set; }
        public int Artal { get; set; }
        public DateOnly Tid { get; set; }   
        public string Infromation { get; set; }

    }
}
