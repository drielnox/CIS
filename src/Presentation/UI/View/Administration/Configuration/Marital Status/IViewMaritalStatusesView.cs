using CIS.Presentation.Model.Administration.MaritalStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIS.Presentation.UI.Contracts.Administration.Configuration.MaritalStatus
{
    public interface IViewMaritalStatusesView
    {
        void SetInitalGridProperties();

        void SetGridData(IEnumerable<ListItemMaritalStatusViewModel> listMaritalStatuses);

        MaritalStatusViewModel ShowNewMaritalStatusForm();

        ListItemMaritalStatusViewModel GetSelectedItem();

        MaritalStatusViewModel ShowModifyMaritalStatusForm(ListItemMaritalStatusViewModel itemSelected);
    }
}
