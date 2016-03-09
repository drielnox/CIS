using CIS.Data.Service.Contract.Repository;
using System;
using System.ServiceModel;

namespace CIS.Data.Service.Contract.UnitOfWork
{
    [ServiceContract]
    public interface IUnitOfWorkContract : IDisposable
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

        [OperationContract]
        void Save();
    }
}
