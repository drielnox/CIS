using CIS.Presentation.Model.Administration.Title;
using System.Collections.Generic;

namespace CIS.Presentation.UI.Contracts.Administration.Configuration.Title
{
    public interface IViewTitlesView
    {
        void SetGridData(IEnumerable<ListItemTitleViewModel> comboData);

        void SetInitialGridProperties();

        TitleViewModel ShowNewTitleForm();

        ListItemTitleViewModel GetSelectedTitle();

        TitleViewModel ShowModifyTitleForm(ListItemTitleViewModel itemSelected);

        bool ShowDeleteTitleDialog(ListItemTitleViewModel itemSelected);
    }
}
