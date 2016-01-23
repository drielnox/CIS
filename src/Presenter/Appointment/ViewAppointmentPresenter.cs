
using CIS.Application.BusinessComponents;
using CIS.Presentation.Model.Appointment;
using CIS.Presentation.UI.Contracts.Appointment;
using System.Collections.Generic;

namespace CIS.Presentation.Logic.Presenter.Appointment
{
    public class ViewAppointmentPresenter
    {
        private IViewAppointmentView _view;
        private AppointmentBusinessLogic _appointmentLogic;

        public ViewAppointmentPresenter(IViewAppointmentView view)
        {
            _view = view;
            _appointmentLogic = new AppointmentBusinessLogic();
        }

        public void LoadAppointments()
        {
            var ap = _appointmentLogic.GetAppointments();
            _view.LoadAppointments(ap);
        }

        public void ApplyFilter()
        {
            IEnumerable<ViewAppointmentFilterViewModel> filters = _view.GetFilters();
            _view.SetFilters(filters);
        }
    }
}
