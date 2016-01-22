
using CIS.Application.BusinessComponents;
using CIS.Presentation.Model.Clinicians;
using CIS.Presentation.UI.Contracts.Administration;

namespace CIS.Presentation.Logic.Presenter.Administration
{
    public class ViewCliniciansPresenter
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
    }
}
