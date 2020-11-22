using MyCare.Domin.Entities;
using MyCare.Models.DTO;
using System.Collections.Generic;

namespace MyCare.Services.Repositories.Interfaces
{
    public interface ITimesheetRepository
    {
        IEnumerable<Timesheet> RetrieveTimesheets(WorkHourDto workHourDto);
    }
}
