using CIS.Data.DataAccess.UnitOfWork;
using CIS.Data.Service.Contract.Repository;
using CIS.Data.Service.Contract.UnitOfWork;
using System;
using System.ServiceModel;

namespace CIS.Data.Service.Proxy.UnitOfWork
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class UnitOfWorkProxy : IUnitOfWorkContract
    {
        private IUnitOfWork _unitOfWork;

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
            get { return _unitOfWork.ClinicianRepository; }
        }

        public IAppointmentRepositoryContract AppointmentRepository
        {
            get { return _unitOfWork.AppointmentRepository; }
        }

        public IPatientRepositoryContract PatientRepository
        {
            get { return _unitOfWork.PatientRepository; }
        }

        public IUserRepositoryContract UserRepository
        {
            get { return _unitOfWork.UserRepository; }
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
