using MyCare.Models.DTO;

namespace MyCare.Services.Services.Interfaces
{
    public interface ITimesheetService
    {
        int GetWorkHours(WorkHourDto workHourDto);
    }
}
