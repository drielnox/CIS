using CIS.Application.Service.Contract;
using CIS.Presentation.Model.Clinicians;
using CIS.Presentation.Model.Common;
using CIS.Presentation.UI.Contracts.Clinicians;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace CIS.Presentation.Logic.Presenter.Clinicians
{
    public class EditClinicPresenter : IDisposable
    {
        private IEditClinicView _view;

        private ChannelFactory<IClinicianContract> _clinicianService;

        public EditClinicPresenter(IEditClinicView view)
        {
            _view = view;

            _clinicianService = new ChannelFactory<IClinicianContract>("ClinicianEndPoint");
        }

        public void LoadTitles()
        {
            IEnumerable<ComboTitleViewModel> titles;

            try
            {
                using (var proxy = _clinicianService.CreateChannel())
                {
                    titles = proxy.GetTitles();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            _view.LoadTitles(titles);
        }

        public void SetFormData(EditClinicViewModel viewModel)
        {
            _view.LoadFormData(viewModel);
        }

        public void Save()
        {
            EditClinicViewModel data = _view.GetFormData();

            try
            {
                using (var proxy = _clinicianService.CreateChannel())
                {
                    proxy.UpdateClinic(data);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
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
                _clinicianService.Close();
                _clinicianService = null;
            }
        }
    }
}
