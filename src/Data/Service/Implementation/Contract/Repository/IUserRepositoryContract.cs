using CIS.Data.Entities;
using CIS.Data.Service.Proxy.Repository;
using System.ServiceModel;

namespace CIS.Data.Service.Contract.Repository
{
    [ServiceContract]
    [ServiceKnownType(typeof(UserRepositoryProxy))]
    public interface IUserRepositoryContract : IRepositoryContract<UserTable, int>
    {
    }
}
