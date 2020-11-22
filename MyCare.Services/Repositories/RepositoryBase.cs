using Microsoft.EntityFrameworkCore;
using MyCare.Domin;
using MyCare.Services.Repositories.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace MyCare.Services.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T>
        where T : class
    {
        private readonly DbContext dBContext;

        public RepositoryBase(DbContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public IQueryable<T> GetList(Expression<Func<T, bool>> predicate)
        {
            try
            {
                return this.dBContext.Set<T>().Where(predicate);
            }
            catch (Exception ex)
            {
                // Log error;
            }
            return null;
        }

        public void Save(T entity)
        {
            try
            {
                this.dBContext.SaveChanges();
            }
            catch (Exception ex)
            {
                // Log error;
            }
        }
    }
}
