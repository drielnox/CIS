using CIS.Data.DataAccess.UnitOfWork;
using CIS.Data.Service.Contract.Repository;
using CIS.Data.Service.Contract.UnitOfWork;
using CIS.Data.Service.Proxy.Repository;
using System;

namespace CIS.Data.Service.Proxy.UnitOfWork
{
    public class UnitOfWorkProxy : IUnitOfWorkContract
    {
        private IUnitOfWork _unitOfWork;

        private IClinicianRepositoryContract _clinicianRepository;
        private IAppointmentRepositoryContract _appointmentRepository;
        private IPatientRepositoryContract _patientRepository;
        private IUserRepositoryContract _userRepository;

        public UnitOfWorkProxy()
        {
            _unitOfWork = new CIS.Data.DataAccess.UnitOfWork.Impl.UnitOfWork();
        }

        ~UnitOfWorkProxy()
        {
            Dispose(false);
        }

        public IClinicianRepositoryContract ClinicianRepository
        {
            get
            {
                return _clinicianRepository ??
                    (_clinicianRepository = new ClinicianRepositoryProxy(_unitOfWork.ClinicianRepository));
            }
        }

        public IAppointmentRepositoryContract AppointmentRepository
        {
            get
            {
                return _appointmentRepository ??
                    (_appointmentRepository = new AppointmentRepositoryProxy(_unitOfWork.AppointmentRepository));
            }
        }

        public IPatientRepositoryContract PatientRepository
        {
            get
            {
                return _patientRepository ??
                    (_patientRepository = new PatientRepositoryProxy(_unitOfWork.PatientRepository));
            }
        }

        public IUserRepositoryContract UserRepository
        {
            get
            {
                return _userRepository ??
                    (_userRepository = new UserRepositoryProxy(_unitOfWork.UserRepository));
            }
        }

        public void Save()
        {
            _unitOfWork.Save();
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
                if (_unitOfWork != null)
                {
                    _unitOfWork.Dispose();
                    _unitOfWork = null;
                }
            }
        }
    }
}
