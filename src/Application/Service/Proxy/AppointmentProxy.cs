using CIS.Application.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIS.Application.Service.Proxy
{
    public class AppointmentProxy : IAppointmentContract
    {
        public void AddAppointment(Presentation.Model.Appointment.BookAppointmentViewModel ap)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Presentation.Model.Common.ClinicListViewModel> GetClinicians()
        {
            throw new NotImplementedException();
        }

        public Presentation.Model.Appointment.PatientOfBookAppointmentViewModel GetPatientForBookAppointment(int patientId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Presentation.Model.Appointment.ViewAppointmentViewModel> GetAppointments()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
