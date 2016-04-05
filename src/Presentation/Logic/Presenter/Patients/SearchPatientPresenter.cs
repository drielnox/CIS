using CIS.Application.Service.Contract;
using CIS.Presentation.Model.Patients;
using CIS.Presentation.UI.Contracts.Patients;
using System;
using System.Linq;
using System.ServiceModel;

namespace CIS.Presentation.Logic.Presenter.Patients
{
    public class SearchPatientPresenter : IDisposable
    {
        private ISearchPatientView _view;

        private ChannelFactory<IPatientContract> _patientService;

        public SearchPatientPresenter(ISearchPatientView view)
        {
            _view = view;

            _patientService = new ChannelFactory<IPatientContract>("PatientEndPoint");
        }

        public void SearchPatient()
        {
            SearchPatientViewModel criteria = _view.GetSearchCriteria();

            PatientsViewModel patients;

            try
            {
                using (var proxy = _patientService.CreateChannel())
                {
                    patients = proxy.SearchPatients(criteria);
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            _view.ShowSearchResult(patients);
        }

        public void ShowPatientData()
        {
            PatientViewModel patient = _view.GetSelectedPatient();
        }

        public bool ValidatePatientId()
        {
            string value = _view.GetPatientId();
            return string.IsNullOrWhiteSpace(value) 
                || value.Any(c => char.IsNumber(c));
        }

        public bool ValidateHospitalNumber()
        {
            string value = _view.GetHospitalNumber();
            return string.IsNullOrWhiteSpace(value)
                || value.Any(c => char.IsNumber(c));
        }

        public bool ValidateLastName()
        {
            string value = _view.GetLastName();
            return string.IsNullOrWhiteSpace(value)
                || value.Any(c => char.IsLetter(c) || char.IsSeparator(c));
        }

        public bool ValidateFirstName()
        {
            string value = _view.GetFirstName();
            return string.IsNullOrWhiteSpace(value)
                || value.Any(c => char.IsNumber(c) || char.IsSeparator(c));
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
                _patientService.Close();
                _patientService = null;
            }
        }
    }
}
