using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCare.Domin.Entities
{
    [Table("Task")]
    public class Task
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int Duration { get; set; }

        [Required]
        public DateTimeOffset Date { get; set; }

        [ForeignKey("Venue_Id")]
        public virtual Venue Venue { get; set; }

        [ForeignKey("People_Id")]
        public virtual People People { get; set; }
    }
}
