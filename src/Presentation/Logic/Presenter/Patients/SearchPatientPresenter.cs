namespace CIS.Presentation.Logic.Presenter.Patients
{
    using Application.Service.Contract;
    using Model.Patients;
    using System;
    using System.Linq;
    using System.ServiceModel;
    using Transversal.SharedKernel.Pattens.MVP;
    using UI.Contracts.Patients;

    public class SearchPatientPresenter : Presenter<ISearchPatientView>, IDisposable
    {
        private ChannelFactory<IPatientContract> _patientService;

        public SearchPatientPresenter(ISearchPatientView view)
            : base(view)
        {
            _patientService = new ChannelFactory<IPatientContract>("PatientEndPoint");
        }

        public void SearchPatient()
        {
            SearchPatientViewModel criteria = View.GetSearchCriteria();

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

            View.ShowSearchResult(patients);
        }

        public void ShowPatientData()
        {
            PatientViewModel patient = View.GetSelectedPatient();
        }

        public bool ValidatePatientId()
        {
            string value = View.GetPatientId();
            return string.IsNullOrWhiteSpace(value)
                || value.Any(c => char.IsNumber(c));
        }

        public bool ValidateHospitalNumber()
        {
            string value = View.GetHospitalNumber();
            return string.IsNullOrWhiteSpace(value)
                || value.Any(c => char.IsNumber(c));
        }

        public bool ValidateLastName()
        {
            string value = View.GetLastName();
            return string.IsNullOrWhiteSpace(value)
                || value.Any(c => char.IsLetter(c) || char.IsSeparator(c));
        }

        public bool ValidateFirstName()
        {
            string value = View.GetFirstName();
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
