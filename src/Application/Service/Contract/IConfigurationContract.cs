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
        [OperationContract]
        IEnumerable<ListItemTitleViewModel> GetTitles();
        [OperationContract]
        void AddTitle(TitleViewModel newTitle);
        [OperationContract]
        void ModifyTitle(TitleViewModel modifiedTitle);
        [OperationContract]
        void DeleteTitle(ListItemTitleViewModel itemSelected);
    }
}
