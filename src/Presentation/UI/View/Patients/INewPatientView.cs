using CIS.Presentation.Model.Common;
using CIS.Presentation.Model.Patients;
using System.Collections.Generic;

namespace CIS.Presentation.UI.Contracts.Patients
{
    public interface INewPatientView
    {
        NewPatientViewModel GetFormData();

        void LoadTitles(IEnumerable<ComboTitleViewModel> titles);

        void LoadGenres(IEnumerable<ComboGenreViewModel> genres);

        void LoadMaritalStatuses(IEnumerable<ComboMaritalStatusViewModel> maritalStatuses);
    }
}
