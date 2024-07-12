using System.ComponentModel.DataAnnotations;

namespace Api.Database.Entities
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string? Treatment { get; set; }

        public string? Design { get; set; }

        public DateTime? DateTime { get; set; }

        public string? Comment { get; set; }
    }
}
