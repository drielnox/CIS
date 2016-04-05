
using CIS.Application.Service.Contract;
using CIS.Presentation.Model.Appointment;
using CIS.Presentation.UI.Contracts.Appointment;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace CIS.Presentation.Logic.Presenter.Appointment
{
    public class ViewAppointmentPresenter : IDisposable
    {
        private IViewAppointmentView _view;

        private ChannelFactory<IAppointmentContract> _appointmentService;

        public ViewAppointmentPresenter(IViewAppointmentView view)
        {
            _view = view;

            _appointmentService = new ChannelFactory<IAppointmentContract>("AppointmentEndPoint");
        }

        public void LoadAppointments()
        {
            IEnumerable<ViewAppointmentViewModel> ap;

            try
            {
                using (var proxy = _appointmentService.CreateChannel())
                {
                    ap = proxy.GetAppointments();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            _view.LoadAppointments(ap);
        }

        public void ApplyFilter()
        {
            IEnumerable<ViewAppointmentFilterViewModel> filters = _view.GetFilters();
            _view.SetFilters(filters);
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
