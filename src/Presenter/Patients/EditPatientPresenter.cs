using CIS.Presentation.Model.Patients;
using CIS.Presentation.UI.Contracts.Patients;

namespace CIS.Presentation.Logic.Presenter.Patients
{
    public class EditPatientPresenter
    {
        private IEditPatientView _view;

        public EditPatientPresenter(IEditPatientView view)
        {
            this._view = view;
        }

        public void LoadPatient()
        {
            
        }

        public void LoadPatient(EditPatientViewModel patient)
        {
            _view.LoadPatient();
        }
    }
}
