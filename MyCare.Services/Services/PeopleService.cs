using MyCare.Domin.Entities;
using MyCare.Models.DTO;
using MyCare.Services.Repositories.Interfaces;
using MyCare.Services.Services.Interfaces;

namespace MyCare.Services.Services
{
    public class PeopleService : IPeopleService
    {
        private readonly IPeopleRepository peopleRepository;

        public PeopleService(IPeopleRepository peopleRepository)
        {
            this.peopleRepository = peopleRepository;
        }

        public int GetWorkHours(WorkHourDto workHourDto)
        {
            throw new System.NotImplementedException();
        }

        public void SavePeople(PeopleDto people)
        {
            var entity = new People
            {
                FirstName = people.FirstName,
                LastName = people.LastName,
                DOB = people.DOB
            };

            this.peopleRepository.SavePeople(entity);
        }
    }
}
