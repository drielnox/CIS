using CIS.Application.BusinessComponents;
using CIS.Application.Entities;
using CIS.Application.Service.Contract;
using CIS.Presentation.Model.Administration.MaritalStatus;
using CIS.Presentation.Model.Administration.Title;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CIS.Application.Service.Proxy
{
    public class ConfigurationProxy : IConfigurationContract
    {
        private bool _disposed = false;

        public ConfigurationProxy()
        {

        }

        ~ConfigurationProxy()
        {
            Dispose(false);
        }

        #region Configuration >> Titles

        public IEnumerable<ListItemTitleViewModel> GetTitles()
        {
            TitleBusinessLogic logic = new TitleBusinessLogic();
            IEnumerable<Title> titles = logic.GetTitles();
            IEnumerable<ListItemTitleViewModel> listItems = titles
                .Select(x => new ListItemTitleViewModel
                {
                    Identifier = x.Identifier,
                    Abbreviation = x.Abbreviation,
                    Description = x.Description
                });
            return listItems;
        }

        public void AddTitle(TitleViewModel newTitle)
        {
            TitleBusinessLogic logic = new TitleBusinessLogic();
            Title title = new Title(newTitle.Identifier, newTitle.Abbreviation, newTitle.Description);
            logic.AddTitle(title);
        }

        public void ModifyTitle(TitleViewModel modifiedTitle)
        {
            TitleBusinessLogic logic = new TitleBusinessLogic();
            Title title = new Title(modifiedTitle.Identifier, modifiedTitle.Abbreviation, modifiedTitle.Description);
            logic.ModifyTitle(title);
        }

        public void DeleteTitle(ListItemTitleViewModel deleteTitle)
        {
            TitleBusinessLogic logic = new TitleBusinessLogic();
            Title title = new Title(deleteTitle.Identifier, deleteTitle.Abbreviation, deleteTitle.Description);
            logic.DeleteTitle(title);
        }

        #endregion

        #region Configuration >> Marital Status

        public IEnumerable<ListItemMaritalStatusViewModel> GetMaritalStatuses()
        {
            throw new NotImplementedException();
        }

        #endregion

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                // free the managed objects
            }

            // free the unmanaged objects

            _disposed = true;
        }
    }
}
