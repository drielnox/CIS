using CIS.Application.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIS.Application.Service.Proxy
{
    public class AdministrationProxy : IConfigurationContract
    {
        public IEnumerable<Presentation.Model.Administration.Title.ListItemTitleViewModel> GetTitles()
        {
            throw new NotImplementedException();
        }

        public void AddTitle(Presentation.Model.Administration.Title.TitleViewModel newTitle)
        {
            throw new NotImplementedException();
        }

        public void ModifyTitle(Presentation.Model.Administration.Title.TitleViewModel modifiedTitle)
        {
            throw new NotImplementedException();
        }

        public void DeleteTitle(Presentation.Model.Administration.Title.ListItemTitleViewModel itemSelected)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Presentation.Model.Administration.MaritalStatus.ListItemMaritalStatusViewModel> GetMaritalStatuses()
        {
            throw new NotImplementedException();
        }

        public void AddMaritalStatus(Presentation.Model.Administration.MaritalStatus.MaritalStatusViewModel newMaritalStatus)
        {
            throw new NotImplementedException();
        }

        public void ModifyMaritalStatus(Presentation.Model.Administration.MaritalStatus.ListItemMaritalStatusViewModel itemSelected)
        {
            throw new NotImplementedException();
        }

        public void DeleteMaritalStatus(Presentation.Model.Administration.MaritalStatus.ListItemMaritalStatusViewModel itemSelected)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
