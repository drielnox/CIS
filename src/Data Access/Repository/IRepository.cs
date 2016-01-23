
namespace CIS.Data.DataAccess.Repository
{
    public interface IRepository<T> : IReadOnlyRepository<T>
        where T : class
    {
        int Add(T entity);
        void Modify(T entity);
        void Remove(T entity);
    }
}
