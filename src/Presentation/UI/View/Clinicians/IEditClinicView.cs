namespace CIS.Presentation.UI.Contracts.Clinicians
{
    using Model.Clinicians;
    using Model.Common;
    using System.Collections.Generic;
    using Transversal.SharedKernel.Patterns.MVP;

    public interface IEditClinicView : IView
    {
        void LoadTitles(IEnumerable<ComboTitleViewModel> titles);

        void LoadFormData(EditClinicViewModel viewModel);

        EditClinicViewModel GetFormData();
    }
}
