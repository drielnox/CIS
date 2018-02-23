using CIS.Application.Service.Contract;
using CIS.Presentation.Model.Appointment;
using CIS.Presentation.Model.Common;
using CIS.Presentation.UI.Contracts;
using CIS.Transversal.SharedKernel.Patterns.MVP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace CIS.Presentation.Logic.Presenter.Appointment
{
    public class BookAppointmentPresenter : Presenter<IBookAppointmentView>, IDisposable
    {
        private ChannelFactory<IAppointmentContract> _appointmentService;

        public BookAppointmentPresenter(IBookAppointmentView view) : base(view)
        {
            _appointmentService = new ChannelFactory<IAppointmentContract>("AppointmentEndPoint");
        }

        public void Save()
        {
            BookAppointmentViewModel ap = View.GetAppointment();

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

            View.LoadClinicians(clinicians);
        }

        public void LoadPatient()
        {
            try
            {
                int patientId = Convert.ToInt32(View.GetPatientId());
                PatientOfBookAppointmentViewModel patient;

                using (var proxy = _appointmentService.CreateChannel())
                {
                    patient = proxy.GetPatientForBookAppointment(patientId);
                }

                View.SetPatientForBookAppointment(patient);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool ValidatePatientId()
        {
            string patientId = View.GetPatientId();

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
