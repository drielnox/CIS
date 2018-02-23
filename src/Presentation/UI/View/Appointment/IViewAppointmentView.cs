
using CIS.Presentation.Model.Appointment;
using CIS.Transversal.SharedKernel.Patterns.MVP;
using System.Collections.Generic;

namespace CIS.Presentation.UI.Contracts.Appointment
{
    public interface IViewAppointmentView : IView
    {
        void LoadAppointments(IEnumerable<ViewAppointmentViewModel> ap);

        IEnumerable<ViewAppointmentFilterViewModel> GetFilters();

        void SetFilters(IEnumerable<ViewAppointmentFilterViewModel> filters);
    }
}
