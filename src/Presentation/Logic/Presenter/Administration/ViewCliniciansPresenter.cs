
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
        private ChannelFactory<IClinicianContract> _clinicianService;

        public ViewCliniciansPresenter(IViewCliniciansView view)
        {
            _view = view;
            _clinicianService = new ChannelFactory<IClinicianContract>("ClinicianEndPoint");
        }

        public void SetInitialControlSettings()
        {
            _view.SetGridInitialSettings();
        }

        public void LoadClinics()
        {
            IEnumerable<ClinicListViewModel> clinicians;

            try
            {
                using (var proxy = _clinicianService.CreateChannel())
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
            ClinicListViewModel selectedClinic = _view.GetSelectedClinic();

            try
            {
                ClinicViewModel rawClinic;

                using (var proxy = _clinicianService.CreateChannel())
                {
                    int id = selectedClinic.Identifier;
                    rawClinic = proxy.GetClinician(id);
                }

                if (rawClinic != null)
                {
                    EditClinicViewModel clinic = new EditClinicViewModel()
                    {
                        Identifier = rawClinic.Identifier
                    };

                    _view.ShowEditClinicForm(clinic);
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
