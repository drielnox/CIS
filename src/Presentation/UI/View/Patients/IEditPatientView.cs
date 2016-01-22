
using CIS.Presentation.Model.Common;
using CIS.Presentation.Model.Patients;
using System.Collections.Generic;

namespace CIS.Presentation.UI.Contracts.Patients
{
    public interface IEditPatientView
    {
        void LoadPatient(EditPatientViewModel patient);

        void LoadTitles(IEnumerable<ComboTitleViewModel> titles);

        void LoadGenres(IEnumerable<ComboGenreViewModel> genrers);

        void LoadMaritalStatuses(IEnumerable<ComboMaritalStatusViewModel> maritalStatuses);

        void LoadNationalIdTypes(IEnumerable<ComboNationalIdTypesViewModel> nationalIdTypes);

        void LoadKinRelationships(IEnumerable<ComboKinRelationshipViewModel> relatioships);

        void LoadClinics(IEnumerable<ClinicListViewModel> clinicians);

        EditPatientViewModel GetPatient();

        int GetCurrentPatientId();

        void SetReport(string report);
    }
}
