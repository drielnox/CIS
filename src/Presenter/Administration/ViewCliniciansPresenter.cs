
using CIS.Application.BusinessComponents;
using CIS.Presentation.Model.Clinicians;
using CIS.Presentation.UI.Contracts.Administration;
using System;

namespace CIS.Presentation.Logic.Presenter.Administration
{
    public class ViewCliniciansPresenter : IDisposable
    {
        private IViewCliniciansView _view;
        private ClinicianBusinessLogic _clinicianLogic;

        public ViewCliniciansPresenter(IViewCliniciansView view)
        {
            _view = view;
            _clinicianLogic = new ClinicianBusinessLogic();
        }

        public void LoadClinics()
        {
            var clinicians = _clinicianLogic.GetClinicians();
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
                _clinicianLogic.Dispose();
                _clinicianLogic = null;
            }
        }
    }
}
