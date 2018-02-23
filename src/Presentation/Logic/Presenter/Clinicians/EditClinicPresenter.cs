using CIS.Application.Service.Contract;
using CIS.Presentation.Model.Clinicians;
using CIS.Presentation.Model.Common;
using CIS.Presentation.UI.Contracts.Clinicians;
using CIS.Transversal.SharedKernel.Patterns.MVP;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace CIS.Presentation.Logic.Presenter.Clinicians
{
    public class EditClinicPresenter : Presenter<IEditClinicView>, IDisposable
    {
        private IEditClinicView View;

        private ChannelFactory<IClinicianContract> _clinicianService;

        public EditClinicPresenter(IEditClinicView view) : base(view)
        {
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

            View.LoadTitles(titles);
        }

        public void SetFormData(EditClinicViewModel viewModel)
        {
            View.LoadFormData(viewModel);
        }

        public void Save()
        {
            EditClinicViewModel data = View.GetFormData();

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
