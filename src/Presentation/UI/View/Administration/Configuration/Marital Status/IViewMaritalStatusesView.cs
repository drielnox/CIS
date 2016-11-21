using CIS.Presentation.Model.Administration.MaritalStatus;
using CIS.Transversal.SharedKernel.Patterns.MVP;
using System.Collections.Generic;

namespace CIS.Presentation.UI.Contracts.Administration.Configuration.MaritalStatus
{
    public interface IViewMaritalStatusesView : IView
    {
        void SetInitalGridProperties();

        void SetGridData(IEnumerable<ListItemMaritalStatusViewModel> listMaritalStatuses);

        MaritalStatusViewModel ShowNewMaritalStatusForm();

        ListItemMaritalStatusViewModel GetSelectedItem();

        MaritalStatusViewModel ShowModifyMaritalStatusForm(ListItemMaritalStatusViewModel itemSelected);

        bool ShowDeleteMaritalStatusDialog(ListItemMaritalStatusViewModel itemSelected);
    }
}
