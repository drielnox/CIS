using CIS.Data.DataFaçade.Repository;
using System;
using System.ServiceModel;

namespace CIS.Data.DataFaçade.UnitOfWork
{
    [ServiceContract]
    public interface IUnitOfWorkService : IDisposable
    {
        ITitleRepositoryService TitleRepository
        {
            [OperationContract]
            get;
        }

        IGenderRepositoryService GenreRepository
        {
            [OperationContract]
            get;
        }

        IMaritalStatusRepositoryService MaritalStatusRepository
        {
            [OperationContract]
            get;
        }

        IClinicianRepositoryService ClinicianRepository
        {
            [OperationContract]
            get;
        }

        IAppointmentRepositoryService AppointmentRepository
        {
            [OperationContract]
            get;
        }

        IPatientRepositoryService PatientRepository
        {
            [OperationContract]
            get;
        }

        [OperationContract]
        void Save();
    }
}
