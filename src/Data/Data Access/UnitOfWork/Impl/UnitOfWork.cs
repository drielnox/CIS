using CIS.Data.DataAccess.Repository;
using CIS.Data.DataAccess.Repository.Impl;
using System;

namespace CIS.Data.DataAccess.UnitOfWork.Impl
{
    public class UnitOfWork : IUnitOfWork
    {
        private ClinicModel _context;

        private IClinicianRepository _clinicianRepository;
        private IAppointmentRepository _appointmentRepository;
        private IPatientRepository _patientRepository;
        private IUserRepository _userRepository;

        public UnitOfWork()
        {
            _context = new ClinicModel();
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }

        public IClinicianRepository ClinicianRepository
        {
            get
            {
                return _clinicianRepository ??
                    (_clinicianRepository = new ClinicianRepository(_context));
            }
        }

        public IAppointmentRepository AppointmentRepository
        {
            get
            {
                return _appointmentRepository ??
                    (_appointmentRepository = new AppointmentRepository(_context));
            }
        }

        public IPatientRepository PatientRepository
        {
            get
            {
                return _patientRepository ??
                    (_patientRepository = new PatientRepository(_context));
            }
        }

        public IUserRepository UserRepository
        {
            get
            {
                return _userRepository ??
                    (_userRepository = new UserRepository(_context));
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }
        }
    }
}
