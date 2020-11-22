using System;

namespace MyCare.Models.DTO
{
    public class WorkHourDto
    {
        public int PeopleId { get; set; }

        public DateTimeOffset StartDate { get; set; }

        public DateTimeOffset EndDate { get; set; }
    }
}
