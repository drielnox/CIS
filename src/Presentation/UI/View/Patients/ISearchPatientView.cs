namespace CIS.Presentation.UI.Contracts.Patients
{
    using Model.Patients;
    using Transversal.SharedKernel.Pattens.MVP;

    public interface ISearchPatientView : IView
    {
        SearchPatientViewModel GetSearchCriteria();

        void ShowSearchResult(PatientsViewModel patients);

        PatientViewModel GetSelectedPatient();

        string GetPatientId();

        string GetHospitalNumber();

        string GetLastName();

        string GetFirstName();
    }
}
