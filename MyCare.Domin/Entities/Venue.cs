using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCare.Domin.Entities
{
    [Table("Venue")]
    public class Venue
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}