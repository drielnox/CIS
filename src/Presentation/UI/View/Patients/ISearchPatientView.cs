using CIS.Presentation.Model.Patients;

namespace CIS.Presentation.UI.Contracts.Patients
{
    public interface ISearchPatientView
    {
        SearchPatientViewModel GetSearchCriteria();

        void ShowSearchResult(PatientsViewModel patients);

        PatientViewModel GetSelectedPatient();
    }
}
