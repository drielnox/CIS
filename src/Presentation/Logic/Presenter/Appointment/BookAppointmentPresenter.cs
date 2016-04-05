using CIS.Application.Service.Contract;
using CIS.Presentation.Model.Appointment;
using CIS.Presentation.Model.Common;
using CIS.Presentation.UI.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace CIS.Presentation.Logic.Presenter.Appointment
{
    public class BookAppointmentPresenter : IDisposable
    {
        private IBookAppointmentView _view;
        
        private ChannelFactory<IAppointmentContract> _appointmentService;

        public BookAppointmentPresenter(IBookAppointmentView view)
        {
            _view = view;

            _appointmentService = new ChannelFactory<IAppointmentContract>("AppointmentEndPoint");
        }

        public void Save()
        {
            BookAppointmentViewModel ap = _view.GetAppointment();

            try
            {
                using (var proxy = _appointmentService.CreateChannel())
                {
                    proxy.AddAppointment(ap);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void LoadClinicians()
        {
            IEnumerable<ClinicListViewModel> clinicians;

            try
            {
                using (var proxy = _appointmentService.CreateChannel())
                {
                    clinicians = proxy.GetClinicians();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            _view.LoadClinicians(clinicians);
        }

        public void LoadPatient()
        {
            try
            {
                int patientId = Convert.ToInt32(_view.GetPatientId());
                PatientOfBookAppointmentViewModel patient;

                using (var proxy = _appointmentService.CreateChannel())
                {
                    patient = proxy.GetPatientForBookAppointment(patientId);
                }

                _view.SetPatientForBookAppointment(patient);
            }
            catch (Exception ex)
            {
                throw;
            }
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
                _appointmentService.Close();
                _appointmentService = null;
            }
        }
    }
}
