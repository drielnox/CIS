using CIS.Data.DataAccess.Repository;
using System.ServiceModel;

namespace CIS.Data.Service.Contract.Repository
{
    [ServiceContract]
    public interface IAppointmentRepositoryContract : IAppointmentRepository
    {
    }
}
