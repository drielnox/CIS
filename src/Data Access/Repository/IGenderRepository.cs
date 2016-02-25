using CIS.Application.Entities;
using System.ServiceModel;

namespace CIS.Data.DataAccess.Repository
{
    [ServiceContract]
    public interface IGenderRepository : IRepository<Gender>
    {
    }
}
