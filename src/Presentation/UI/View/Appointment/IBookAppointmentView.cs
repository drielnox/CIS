using CIS.Presentation.Model.Appointment;
using CIS.Presentation.Model.Common;
using CIS.Transversal.SharedKernel.Patterns.MVP;
using System.Collections.Generic;

namespace CIS.Presentation.UI.Contracts
{
    public interface IBookAppointmentView : IView
    {
        BookAppointmentViewModel GetAppointment();

        void LoadClinicians(IEnumerable<ClinicListViewModel> clinicians);

        string GetPatientId();

        void SetPatientForBookAppointment(PatientOfBookAppointmentViewModel patient);
    }
}
