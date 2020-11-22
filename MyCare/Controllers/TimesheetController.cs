using Microsoft.AspNetCore.Mvc;
using MyCare.Models.DTO;
using MyCare.Services.Services.Interfaces;

namespace MyCare.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TimesheetController : ControllerBase
    {
        private readonly ITimesheetService timesheetService;

        public TimesheetController(ITimesheetService timesheetService)
        {
            this.timesheetService = timesheetService;
        }

        [HttpPost]
        public IActionResult GetWorkHours(WorkHourDto workHourDto)
        {
            if (ModelState.IsValid)
            {
                var hours = this.timesheetService.GetWorkHours(workHourDto);
                return Ok(hours);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
