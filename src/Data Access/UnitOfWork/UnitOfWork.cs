using CIS.Data.DataAccess.Repository;
using System;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace CIS.Data.DataAccess.UnitOfWork
{
    [DataContract]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class UnitOfWork : IUnitOfWork
    {
        private ClinicModel _context;
        
        private ITitleRepository _titleRepository;
        private IGenderRepository _genderRepository;
        private IMaritalStatusRepository _maritalStatusRepository;
        private IClinicianRepository _clinicianRepository;
        private IAppointmentRepository _appointmentRepository;
        private IPatientRepository _patientRepository;

        public UnitOfWork()
        {
            _context = new ClinicModel();
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }

        [DataMember]
        public ITitleRepository TitleRepository
        {
            get 
            { 
                return _titleRepository ??
                    (_titleRepository = new TitleRepository(_context));
            }
        }

        [DataMember]
        public IGenderRepository GenreRepository
        {
            get 
            {
                return _genderRepository ??
                    (_genderRepository = new GenderRepository(_context));
            }
        }

        [DataMember]
        public IMaritalStatusRepository MaritalStatusRepository
        {
            get 
            { 
                return _maritalStatusRepository ??
                    (_maritalStatusRepository = new MaritalStatusRepository(_context)); 
            }
        }

        [DataMember]
        public IClinicianRepository ClinicianRepository
        {
            get 
            { 
                return _clinicianRepository ??
                    (_clinicianRepository = new ClinicianRepository(_context));
            }
        }

        [DataMember]
        public IAppointmentRepository AppointmentRepository
        {
            get 
            {
                return _appointmentRepository ??
                    (_appointmentRepository = new AppointmentRepository(_context));
            }
        }

        [DataMember]
        public IPatientRepository PatientRepository 
        {
            get
            { 
                return _patientRepository ??
                    (_patientRepository = new PatientRepository(_context));
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
