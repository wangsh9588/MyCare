using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCare.Domin.Entities
{
    [Table("Timesheet")]
    public class Timesheet
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Task_Id")]
        public virtual Task Task { get; set; }

        [ForeignKey("People_Id")]
        public virtual People People { get; set; }

        [Required]
        public DateTimeOffset Date { get; set; }

        // Hours
        [Required]
        public int Duration { get; set; }
    }
}
