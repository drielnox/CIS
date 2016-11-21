
using CIS.Application.Service.Contract;
using CIS.Presentation.Model.Clinicians;
using CIS.Presentation.Model.Common;
using CIS.Presentation.UI.Contracts.Administration;
using CIS.Transversal.SharedKernel.Patterns.MVP;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace CIS.Presentation.Logic.Presenter.Administration
{
    public class ViewCliniciansPresenter : Presenter<IViewCliniciansView>, IDisposable
    {
        private ChannelFactory<IClinicianContract> _clinicianService;

        public ViewCliniciansPresenter(IViewCliniciansView view) : base(view)
        {
            _clinicianService = new ChannelFactory<IClinicianContract>("ClinicianEndPoint");
        }

        public void SetInitialControlSettings()
        {
            View.SetGridInitialSettings();
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

            View.LoadClinicians(clinicians);
        }

        public void ShowEditClinic()
        {
            ClinicListViewModel selectedClinic = View.GetSelectedClinic();

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

                    View.ShowEditClinicForm(clinic);
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
