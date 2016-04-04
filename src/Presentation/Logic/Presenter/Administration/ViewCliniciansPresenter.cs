
using CIS.Application.BusinessComponents;
using CIS.Application.Service.Contract;
using CIS.Presentation.Model.Clinicians;
using CIS.Presentation.Model.Common;
using CIS.Presentation.UI.Contracts.Administration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ServiceModel;

namespace CIS.Presentation.Logic.Presenter.Administration
{
    public class ViewCliniciansPresenter : IDisposable
    {
        private IViewCliniciansView _view;
        private ChannelFactory<IAdministrationContract> channel;

        public ViewCliniciansPresenter(IViewCliniciansView view)
        {
            _view = view;
            channel = new ChannelFactory<IAdministrationContract>("AdministrationEndPoint");
        }

        public void LoadClinics()
        {
            IEnumerable<ClinicListViewModel> clinicians;

            try
            {
                using (var proxy = channel.CreateChannel())
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

        public void ShowEditClinic()
        {
            EditClinicViewModel clinic = _view.GetClinic();
            _view.ShowEditClinicForm(clinic);
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
                channel.Close();
                channel = null;
            }
        }
    }
}
