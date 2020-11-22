using MyCare.Models.DTO;
using MyCare.Services.Repositories.Interfaces;
using MyCare.Services.Services.Interfaces;
using System.Linq;

namespace MyCare.Services.Services
{
    public class TimesheetService : ITimesheetService
    {
        private readonly ITimesheetRepository timesheetRepository;

        public TimesheetService(ITimesheetRepository timesheetRepository)
        {
            this.timesheetRepository = timesheetRepository;
        }

        public int GetWorkHours(WorkHourDto workHourDto)
        {
            var timesheets = this.timesheetRepository.RetrieveTimesheets(workHourDto);
            if (timesheets.Any())
            {
                return timesheets.Select(t => t.Duration).Sum();
            }

            return 0;
        }
    }
}
