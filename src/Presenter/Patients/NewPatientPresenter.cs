using CIS.Application.BusinessComponents;
using CIS.Presentation.Model.Patients;
using CIS.Presentation.UI.Contracts.Patients;

namespace CIS.Presentation.Logic.Presenter.Patients
{
    public class NewPatientPresenter
    {
        private INewPatientView _view;
        private PatientBusinessLogic _logic;

        public NewPatientPresenter(INewPatientView view)
        {
            _view = view;
            _logic = new PatientBusinessLogic();
        }

        public void Save()
        {
            NewPatientViewModel data = _view.GetFormData();
            _logic.AddPatient(data);
        }

        public void LoadTitles()
        {
            throw new System.NotImplementedException();
        }
    }
}
