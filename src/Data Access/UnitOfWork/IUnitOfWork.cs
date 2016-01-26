
using CIS.Data.DataAccess.Repository;
using System;

namespace CIS.Data.DataAccess.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ITitleRepository TitleRepository { get; }

        IGenderRepository GenreRepository { get; }

        IMaritalStatusRepository MaritalStatusRepository { get; }

        IClinicianRepository ClinicianRepository { get; }

        IAppointmentRepository AppointmentRepository { get; }

        void Save();
    }
}
