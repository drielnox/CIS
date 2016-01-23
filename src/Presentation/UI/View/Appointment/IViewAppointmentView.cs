
using CIS.Presentation.Model.Appointment;
using System.Collections.Generic;

namespace CIS.Presentation.UI.Contracts.Appointment
{
    public interface IViewAppointmentView
    {
        void LoadAppointments(IEnumerable<ViewAppointmentViewModel> ap);

        IEnumerable<ViewAppointmentFilterViewModel> GetFilters();

        void SetFilters(IEnumerable<ViewAppointmentFilterViewModel> filters);
    }
}
