using CIS.Application.BusinessComponents;
using CIS.Application.Service.Contract;
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

        public IEnumerable<ListItemTitleViewModel> GetTitles()
        {
            var logic = new TitleBusinessLogic();
            var titles = logic.GetTitles();
            var listItems = titles
                .Select(x => new ListItemTitleViewModel
                {
                    Identifier = x.Identifier,
                    Abbreviation = x.Abbreviation,
                    Description = x.Description
                });
            return listItems;
        }

        ~ConfigurationProxy()
        {
            Dispose(false);
        }

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
