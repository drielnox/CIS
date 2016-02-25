
using CIS.Data.DataAccess.Repository;
using System;
using System.ServiceModel;

namespace CIS.Data.DataAccess.UnitOfWork
{
    [ServiceContract]
    public interface IUnitOfWork : IDisposable
    {
        ITitleRepository TitleRepository
        {
            [OperationContract]
            get;
        }

        IGenderRepository GenreRepository
        {
            [OperationContract]
            get;
        }

        IMaritalStatusRepository MaritalStatusRepository
        {
            [OperationContract]
            get;
        }

        IClinicianRepository ClinicianRepository
        {
            [OperationContract]
            get;
        }

        IAppointmentRepository AppointmentRepository
        {
            [OperationContract]
            get;
        }

        IPatientRepository PatientRepository
        {
            [OperationContract]
            get;
        }

        [OperationContract]
        void Save();
    }
}
