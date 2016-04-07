using CIS.Presentation.Model;
using CIS.Presentation.Model.Common;
using System.Collections.Generic;

namespace CIS.Presentation.UI.Contracts
{
    public interface INewClinicView
    {
        void LoadTitles(IEnumerable<ComboTitleViewModel> titles);
        int GetSelectedTitle();
        NewClinicPresentationModel GetClinicianData();
    }
}
