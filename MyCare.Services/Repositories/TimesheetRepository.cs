using MyCare.Domin;
using MyCare.Domin.Entities;
using MyCare.Models.DTO;
using MyCare.Services.Repositories.Interfaces;
using System.Collections.Generic;

namespace MyCare.Services.Repositories
{
    public class TimesheetRepository : RepositoryBase<Timesheet>, ITimesheetRepository
    {
        public TimesheetRepository(MyCareDBContext myCareDbContext) : base(myCareDbContext)
        {

        }

        public IEnumerable<Timesheet> RetrieveTimesheets(WorkHourDto workHourDto)
        {
            return base.GetList(p => p.People.Id == workHourDto.PeopleId && p.Date >= workHourDto.StartDate && p.Date <= workHourDto.EndDate);
        }
    }
}
