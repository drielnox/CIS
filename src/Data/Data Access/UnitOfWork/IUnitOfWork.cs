using CIS.Data.DataAccess.Repository;
using System;

namespace CIS.Data.DataAccess.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IClinicianRepository ClinicianRepository { get; }
        IAppointmentRepository AppointmentRepository { get; }
        IPatientRepository PatientRepository { get; }
        IUserRepository UserRepository { get; }
        void Save();
    }
}
