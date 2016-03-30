using CIS.Presentation.Model.Administration.MaritalStatus;
using CIS.Presentation.Model.Administration.Title;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace CIS.Application.Service.Contract
{
    [ServiceContract]
    public interface IConfigurationContract : IDisposable
    {
        #region Configuration >> Titles

        [OperationContract]
        IEnumerable<ListItemTitleViewModel> GetTitles();
        [OperationContract]
        void AddTitle(TitleViewModel newTitle);
        [OperationContract]
        void ModifyTitle(TitleViewModel modifiedTitle);
        [OperationContract]
        void DeleteTitle(ListItemTitleViewModel itemSelected);

        #endregion

        #region Configuration >> Marital Status

        [OperationContract]
        IEnumerable<ListItemMaritalStatusViewModel> GetMaritalStatuses();
        [OperationContract]
        void AddMaritalStatus(MaritalStatusViewModel newMaritalStatus);
        [OperationContract]
        void ModifyMaritalStatus(ListItemMaritalStatusViewModel itemSelected);
        [OperationContract]
        void DeleteMaritalStatus(ListItemMaritalStatusViewModel itemSelected);

        #endregion
    }
}
