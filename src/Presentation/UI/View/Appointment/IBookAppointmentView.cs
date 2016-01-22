using CIS.Presentation.Model.Appointment;
using CIS.Presentation.Model.Common;
using System.Collections.Generic;

namespace CIS.Presentation.UI.Contracts
{
    public interface IBookAppointmentView
    {
        BookAppointmentViewModel GetAppointment();

        void LoadClinicians(IEnumerable<ClinicListViewModel> clinicians);

        string GetPatientId();

        void SetPatientForBookAppointment(PatientOfBookAppointmentViewModel patient);
    }
}
