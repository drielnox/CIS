using CIS.Application.Service.Contract;
using CIS.Presentation.Model;
using CIS.Presentation.Model.Common;
using CIS.Presentation.UI.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace CIS.Presentation.Logic.Presenter
{
    public class NewClinicPresenter : IDisposable
    {
        private INewClinicView _view;

        private ChannelFactory<IClinicianContract> _clinicianService;

        public NewClinicPresenter(INewClinicView view)
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

        public bool ValidateClinicNumber(string p)
        {
            return string.IsNullOrWhiteSpace(p) || p.Any(c => !char.IsNumber(c));
        }

        public bool ValidateLastName(string p)
        {
            return string.IsNullOrWhiteSpace(p) || p.Any(c => !char.IsLetter(c));
        }

        public NewClinicPresentationModel GetClinicianData()
        {
            return _view.GetClinicianData();
        }

        public void Save(NewClinicPresentationModel model)
        {
            try
            {
                using (var proxy = _clinicianService.CreateChannel())
                {
                    proxy.AddClinic(model);
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
