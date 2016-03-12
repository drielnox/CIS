using CIS.Data.Service.Contract.Repository;
using CIS.Data.Service.Proxy.UnitOfWork;
using System;
using System.ServiceModel;

namespace CIS.Data.Service.Contract.UnitOfWork
{
    [ServiceContract]
    [ServiceKnownType(typeof(UnitOfWorkProxy))]
    public interface IUnitOfWorkContract : IGenericUnitOfWorkContract
    {
        IClinicianRepositoryContract ClinicianRepository
        {
            [OperationContract]
            get;
        }

        IAppointmentRepositoryContract AppointmentRepository
        {
            [OperationContract]
            get;
        }

        IPatientRepositoryContract PatientRepository
        {
            [OperationContract]
            get;
        }

        IUserRepositoryContract UserRepository
        {
            [OperationContract]
            get;
        }
    }
}
