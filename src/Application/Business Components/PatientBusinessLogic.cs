using CIS.Application.Entities;
using System;
using System.Linq;

namespace CIS.Application.BusinessComponents
{
    public class PatientBusinessLogic : IDisposable
    {
#if !DEBUG
        private IUnitOfWork _unitOfWork;
#endif

        public PatientBusinessLogic()
        {
#if !DEBUG
            _unitOfWork = new UnitOfWork();
#endif
        }

        public void AddPatient(Patient data)
        {
            throw new NotImplementedException();
        }

        public Patient SearchPatients(Patient criteria)
        {
#if !DEBUG
            var patients = _unitOfWork.PatientRepository
                .GetAll()
                .Where(x => x.Identifier == int.Parse(criteria.PatientId))
                .Where(x => x.FirstName == criteria.FirstName)
                .Where(x => x.LastName == criteria.LastName)
                .Where(x => x.HospitalNumber == int.Parse(criteria.HospitalNumber))
                .Select(x => new PatientViewModel 
                { 
                     Identifier = x.Identifier.ToString(),
                     FirstName = x.FirstName,
                     LastName = x.LastName
                });

            return new PatientsViewModel
            {
                Patients = patients
            };
#else
            return null;
#endif
        }

        public void UpdatePatient(Patient patient)
        {
            throw new NotImplementedException();
        }

        public void DeletePatient(int patientId)
        {
            throw new NotImplementedException();
        }

        public Patient GetPatient()
        {
            throw new NotImplementedException();
        }

        public Patient GetPatientForBookAppointment(int patientId)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
#if !DEBUG
            Dispose(true);
            GC.SuppressFinalize(this);
#endif

        }

        protected virtual void Dispose(bool disposing)
        {
#if !DEBUG
            if (disposing)
            {
                _unitOfWork.Dispose();
                _unitOfWork = null;
            }
#endif
        }
    }
}
