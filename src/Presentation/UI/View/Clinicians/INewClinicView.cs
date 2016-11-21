namespace CIS.Presentation.UI.Contracts
{
    using Model;
    using Model.Common;
    using System.Collections.Generic;
    using Transversal.SharedKernel.Patterns.MVP;

    public interface INewClinicView : IView
    {
        void LoadTitles(IEnumerable<ComboTitleViewModel> titles);
        int GetSelectedTitle();
        NewClinicPresentationModel GetClinicianData();
    }
}
