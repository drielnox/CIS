namespace CIS.Presentation.UI.Contracts.Patients
{
    using Model.Common;
    using Model.Patients;
    using System.Collections.Generic;
    using Transversal.SharedKernel.Patterns.MVP;

    public interface IEditPatientView : IView
    {
        void LoadPatient(EditPatientViewModel patient);

        void LoadTitles(IEnumerable<ComboTitleViewModel> titles);

        void LoadGenders(IEnumerable<ComboGenreViewModel> genrers);

        void LoadMaritalStatuses(IEnumerable<ComboMaritalStatusViewModel> maritalStatuses);

        void LoadNationalIdTypes(IEnumerable<ComboNationalIdTypesViewModel> nationalIdTypes);

        void LoadKinRelationships(IEnumerable<ComboKinRelationshipViewModel> relatioships);

        void LoadClinics(IEnumerable<ClinicListViewModel> clinicians);

        EditPatientViewModel GetPatient();

        int GetCurrentPatientId();

        void SetReport(string report);
    }
}
