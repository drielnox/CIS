using CIS.Presentation.Model.Patients;

namespace CIS.Presentation.UI.Contracts.Patients
{
    public interface INewPatientView
    {
        NewPatientViewModel GetFormData();
    }
}
