using System.Collections.Generic;
using System.ServiceModel;

namespace CIS.Data.DataAccess.Repository
{
    [ServiceContract]
    public interface IReadOnlyRepository<T> 
        where T : class
    {
        [OperationContract]
        T GetById(int Id);

        [OperationContract]
        IEnumerable<T> GetAll();
    }
}
