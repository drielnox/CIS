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

        public bool ValidatePatientId()
        {
            string value = _view.GetPatientId();
            return string.IsNullOrWhiteSpace(value);
        }

        public bool ValidateHospitalNumber()
        {
            string value = _view.GetHospitalNumber();
            return string.IsNullOrWhiteSpace(value);
        }

        public bool ValidateLastName()
        {
            string value = _view.GetLastName();
            return string.IsNullOrWhiteSpace(value);
        }

        public bool ValidateFirstName()
        {
            string value = _view.GetFirstName();
            return string.IsNullOrWhiteSpace(value);
        }

        public void ValidateSearchFields()
        {
            bool asd = _view.RequestValidatePatientId();
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
