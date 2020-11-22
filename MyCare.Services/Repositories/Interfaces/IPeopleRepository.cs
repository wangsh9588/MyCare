using MyCare.Domin.Entities;
using MyCare.Models.DTO;

namespace MyCare.Services.Repositories.Interfaces
{
    public interface IPeopleRepository
    {
        void SavePeople(People people);
    }
}
