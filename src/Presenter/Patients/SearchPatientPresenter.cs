using CIS.Application.BusinessComponents;
using CIS.Presentation.Model.Patients;
using CIS.Presentation.UI.Contracts.Patients;
using System;

namespace CIS.Presentation.Logic.Presenter.Patients
{
    public class SearchPatientPresenter : IDisposable
    {
        private ISearchPatientView _view;
        private PatientBusinessLogic _logic;

        public SearchPatientPresenter(ISearchPatientView view)
        {
            _view = view;
            _logic = new PatientBusinessLogic();
        }

        public void SearchPatient()
        {
            SearchPatientViewModel criteria = _view.GetSearchCriteria();
            PatientsViewModel patients = _logic.SearchPatients(criteria);
            _view.ShowSearchResult(patients);
        }

        public void ShowPatientData()
        {
            PatientViewModel patient = _view.GetSelectedPatient();
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
                _logic.Dispose();
                _logic = null;
            }
        }
    }
}
