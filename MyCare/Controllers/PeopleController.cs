using Microsoft.AspNetCore.Mvc;
using MyCare.Models.DTO;
using MyCare.Services.Services.Interfaces;

namespace MyCare.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly IPeopleService peopleService;

        public PeopleController(IPeopleService peopleService)
        {
            this.peopleService = peopleService;
        }

        [HttpPost]
        public IActionResult Create(PeopleDto people)
        {
            try
            {
                this.peopleService.SavePeople(people);
            }
            catch
            {
                // Log error
            }

            return Ok();
        }
    }
}
