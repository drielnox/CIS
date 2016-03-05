using CIS.Data.DataAccess.Repository;
using System.ServiceModel;

namespace CIS.Data.DataFaçade.Repository
{
    [ServiceContract]
    public interface IGenderRepositoryService : IGenderRepository
    {
    }
}
