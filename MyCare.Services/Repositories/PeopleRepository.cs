using MyCare.Domin;
using MyCare.Domin.Entities;
using MyCare.Models.DTO;
using MyCare.Services.Repositories.Interfaces;
using System;
using System.Linq.Expressions;

namespace MyCare.Services.Repositories
{
    public class PeopleRepository : RepositoryBase<People>, IPeopleRepository
    {
        public PeopleRepository(MyCareDBContext myCareDbContext) : base(myCareDbContext)
        {
        }

        public void SavePeople(People people)
        {
            base.Save(people);
        }
    }
}
