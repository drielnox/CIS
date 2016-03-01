using CIS.Application.BusinessComponents;
using CIS.Presentation.Model.Appointment;
using CIS.Presentation.UI.Contracts;
using System;
using System.Linq;

namespace CIS.Presentation.Logic.Presenter.Appointment
{
    public class BookAppointmentPresenter : IDisposable
    {
        private IBookAppointmentView _view;
        private AppointmentBusinessLogic _appointmentLogic;
        private ClinicianBusinessLogic _clinicianLogic;
        private PatientBusinessLogic _patientLogic;

        public BookAppointmentPresenter(IBookAppointmentView view)
        {
            _view = view;
            _appointmentLogic = new AppointmentBusinessLogic();
            _clinicianLogic = new ClinicianBusinessLogic();
            _patientLogic = new PatientBusinessLogic();
        }

        public void Save()
        {
            var ap = _view.GetAppointment();
            _appointmentLogic.AddAppointment(ap);
        }

        public void LoadClinicians()
        {
            var clinicians = _clinicianLogic.GetClinicians();
            _view.LoadClinicians(clinicians);
        }

        public void LoadPatient()
        {
            int patientId = Convert.ToInt32(_view.GetPatientId());
            PatientOfBookAppointmentViewModel patient = _patientLogic.GetPatientForBookAppointment(patientId);
            _view.SetPatientForBookAppointment(patient);
        }

        public bool ValidatePatientId()
        {
            string patientId = _view.GetPatientId();

            return string.IsNullOrWhiteSpace(patientId) || patientId.Any(c => !char.IsNumber(c));
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
                _appointmentLogic.Dispose();
                _appointmentLogic = null;
                _clinicianLogic.Dispose();
                _clinicianLogic = null;
                _patientLogic.Dispose();
                _patientLogic = null;
            }
        }
    }
}
