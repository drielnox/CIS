using CIS.Data.DataFaçade.Repository;
using System;
using System.ServiceModel;

namespace CIS.Data.DataFaçade.UnitOfWork
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class UnitOfWorkService : IUnitOfWorkService
    {
        private IUnitOfWorkService _unitOfWork;

        public UnitOfWorkService()
        {
            _unitOfWork = new UnitOfWorkService();
        }

        ~UnitOfWorkService()
        {
            Dispose(false);
        }

        public ITitleRepositoryService TitleRepository
        {
            get { return _unitOfWork.TitleRepository; }
        }

        public IGenderRepositoryService GenreRepository
        {
            get { return _unitOfWork.GenreRepository; }
        }

        public IMaritalStatusRepositoryService MaritalStatusRepository
        {
            get { return _unitOfWork.MaritalStatusRepository; }
        }

        public IClinicianRepositoryService ClinicianRepository
        {
            get { return _unitOfWork.ClinicianRepository; }
        }

        public IAppointmentRepositoryService AppointmentRepository
        {
            get { return _unitOfWork.AppointmentRepository; }
        }

        public IPatientRepositoryService PatientRepository
        {
            get { return _unitOfWork.PatientRepository; }
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
