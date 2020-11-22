namespace MyCare.Services.Repositories.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        void Save(T entity);
    }
}
