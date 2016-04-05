using CIS.Presentation.Model.Administration.MaritalStatus;
using System.Collections.Generic;

namespace CIS.Presentation.UI.Contracts.Administration.Configuration.MaritalStatus
{
    public interface IViewMaritalStatusesView
    {
        void SetInitalGridProperties();

        void SetGridData(IEnumerable<ListItemMaritalStatusViewModel> listMaritalStatuses);

        MaritalStatusViewModel ShowNewMaritalStatusForm();

        ListItemMaritalStatusViewModel GetSelectedItem();

        MaritalStatusViewModel ShowModifyMaritalStatusForm(ListItemMaritalStatusViewModel itemSelected);

        bool ShowDeleteMaritalStatusDialog(ListItemMaritalStatusViewModel itemSelected);
    }
}
