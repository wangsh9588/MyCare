using MyCare.Domin.Entities;
using MyCare.Models.DTO;

namespace MyCare.Services.Services.Interfaces
{
    public interface IPeopleService
    {
        void SavePeople(PeopleDto people);
    }
}
