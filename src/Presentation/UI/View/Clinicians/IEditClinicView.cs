using CIS.Presentation.Model;
using CIS.Presentation.Model.Clinicians;
using System.Collections.Generic;

namespace CIS.Presentation.UI.Contracts.Clinicians
{
    public interface IEditClinicView
    {
        void LoadTitles(IEnumerable<ComboTitleViewModel> titles);

        void LoadFormData(EditClinicViewModel viewModel);

        EditClinicViewModel GetFormData();
    }
}
