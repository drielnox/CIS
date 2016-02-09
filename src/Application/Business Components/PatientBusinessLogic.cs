using CIS.Data.DataAccess.UnitOfWork;
using CIS.Presentation.Model.Appointment;
using CIS.Presentation.Model.Patients;
using System;
using System.Linq;

namespace CIS.Application.BusinessComponents
{
    public class PatientBusinessLogic : IDisposable
    {
        private IUnitOfWork _unitOfWork;

        public PatientBusinessLogic()
        {
            _unitOfWork = new UnitOfWork();
        }

        public void AddPatient(NewPatientViewModel data)
        {
            throw new NotImplementedException();
        }

        public PatientsViewModel SearchPatients(SearchPatientViewModel criteria)
        {
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
        }

        public void UpdatePatient(EditPatientViewModel patient)
        {
            throw new NotImplementedException();
        }

        public void DeletePatient(int patientId)
        {
            throw new NotImplementedException();
        }

        public EditPatientViewModel GetPatient()
        {
            throw new NotImplementedException();
        }

        public PatientOfBookAppointmentViewModel GetPatientForBookAppointment(int patientId)
        {
            throw new NotImplementedException();
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
                _unitOfWork.Dispose();
                _unitOfWork = null;
            }
        }
    }
}
