using CIS.Application.Service.Contract;
using CIS.Presentation.Model.Administration.MaritalStatus;
using CIS.Presentation.UI.Contracts.Administration.Configuration.MaritalStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace CIS.Presentation.Logic.Presenter.Administration.Configuration.MaritalStatus
{
    public class ViewMaritalStatusesPresenter
    {
        private IViewMaritalStatusesView _view;

        private ChannelFactory<IConfigurationContract> channel;

        public ViewMaritalStatusesPresenter(IViewMaritalStatusesView view)
        {
            _view = view;

            channel = new ChannelFactory<IConfigurationContract>("ConfigurationEndPoint");
        }

        public void SetInitalControlProperties()
        {
            _view.SetInitalGridProperties();
        }

        public void LoadMaritalStatuses()
        {
            IEnumerable<ListItemMaritalStatusViewModel> listMaritalStatuses;

            using (var proxy = channel.CreateChannel())
            {
                listMaritalStatuses = proxy.GetMaritalStatuses();
            }

            _view.SetGridData(listMaritalStatuses);
        }

        public void AddNewMaritalStatus()
        {
            MaritalStatusViewModel newMaritalStatus = _view.ShowNewMaritalStatusForm();

            if (newMaritalStatus != null)
            {
                IEnumerable<ListItemMaritalStatusViewModel> listMaritalStatuses;

                try
                {
                    using (var proxy = channel.CreateChannel())
                    {
                        proxy.AddMaritalStatus(newMaritalStatus);
                        listMaritalStatuses = proxy.GetMaritalStatuses();
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }

                _view.SetGridData(listMaritalStatuses);
            }
        }

        public void ModifyMaritalStatus()
        {
            ListItemMaritalStatusViewModel itemSelected = _view.GetSelectedItem();

            if (itemSelected != null)
            {
                MaritalStatusViewModel modifiedMaritalStatus = _view.ShowModifyMaritalStatusForm(itemSelected);

                if (true)
                {
                    IEnumerable<ListItemMaritalStatusViewModel> listMaritalStatuses;

                    try
                    {
                        using (var proxy = channel.CreateChannel())
                        {
                            proxy.ModifyMaritalStatus(itemSelected);
                            listMaritalStatuses = proxy.GetMaritalStatuses();
                        }
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }

                    _view.SetGridData(listMaritalStatuses);
                }
            }
        }

        public void DeleteMaritalStatus()
        {
            ListItemMaritalStatusViewModel itemSelected = _view.GetSelectedItem();

            if (itemSelected != null)
            {
                bool delete = _view.ShowDeleteMaritalStatusDialog(itemSelected);

                if (delete)
                {
                    IEnumerable<ListItemMaritalStatusViewModel> maritalStatuses;

                    try
                    {
                        using (var proxy = channel.CreateChannel())
                        {
                            proxy.DeleteMaritalStatus(itemSelected);
                            maritalStatuses = proxy.GetMaritalStatuses();
                        }
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }

                    _view.SetGridData(maritalStatuses);
                }
            }
        }
    }
}
