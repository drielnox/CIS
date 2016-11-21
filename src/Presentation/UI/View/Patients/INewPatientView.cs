namespace CIS.Presentation.UI.Contracts.Patients
{
    using Model.Common;
    using Model.Patients;
    using System.Collections.Generic;
    using Transversal.SharedKernel.Patterns.MVP;

    public interface INewPatientView : IView
    {
        NewPatientViewModel GetFormData();
        void LoadTitles(IEnumerable<ComboTitleViewModel> titles);
        void LoadGenres(IEnumerable<ComboGenreViewModel> genres);
        void LoadMaritalStatuses(IEnumerable<ComboMaritalStatusViewModel> maritalStatuses);
    }
}
