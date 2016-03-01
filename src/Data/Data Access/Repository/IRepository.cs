using System.ServiceModel;

namespace CIS.Data.DataAccess.Repository
{
    [ServiceContract]
    public interface IRepository<T> : IReadOnlyRepository<T>
        where T : class
    {
        [OperationContract]
        int Add(T entity);

        [OperationContract]
        void Modify(T entity);

        [OperationContract]
        void Remove(T entity);
    }
}
