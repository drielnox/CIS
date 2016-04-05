using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace CIS.Application.Service.Contract
{
    [ServiceContract]
    public interface IAppointmentContract : IDisposable
    {
        [OperationContract]
        void AddAppointment(Presentation.Model.Appointment.BookAppointmentViewModel ap);
        [OperationContract]
        IEnumerable<Presentation.Model.Common.ClinicListViewModel> GetClinicians();
        [OperationContract]
        Presentation.Model.Appointment.PatientOfBookAppointmentViewModel GetPatientForBookAppointment(int patientId);
        [OperationContract]
        IEnumerable<Presentation.Model.Appointment.ViewAppointmentViewModel> GetAppointments();
    }
}
