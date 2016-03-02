using System.Collections.Generic;

namespace CIS.Data.DataAccess.Repository
{
    public interface IReadOnlyRepository<T>
        where T : class
    {
        T GetById(int Id);
        IEnumerable<T> GetAll();
    }
}
