using CIS.Application.Service.Contract;
using CIS.Presentation.Model.Administration.MaritalStatus;
using CIS.Presentation.UI.Contracts.Administration.Configuration.MaritalStatus;
using CIS.Transversal.SharedKernel.Patterns.MVP;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace CIS.Presentation.Logic.Presenter.Administration.Configuration.MaritalStatus
{
    public class ViewMaritalStatusesPresenter : Presenter<IViewMaritalStatusesView>
    {

        private ChannelFactory<IConfigurationContract> channel;

        public ViewMaritalStatusesPresenter(IViewMaritalStatusesView view) : base(view)
        {


            channel = new ChannelFactory<IConfigurationContract>("ConfigurationEndPoint");
        }

        public void SetInitalControlProperties()
        {
            View.SetInitalGridProperties();
        }

        public void LoadMaritalStatuses()
        {
            IEnumerable<ListItemMaritalStatusViewModel> listMaritalStatuses;

            using (var proxy = channel.CreateChannel())
            {
                listMaritalStatuses = proxy.GetMaritalStatuses();
            }

            View.SetGridData(listMaritalStatuses);
        }

        public void AddNewMaritalStatus()
        {
            MaritalStatusViewModel newMaritalStatus = View.ShowNewMaritalStatusForm();

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

                View.SetGridData(listMaritalStatuses);
            }
        }

        public void ModifyMaritalStatus()
        {
            ListItemMaritalStatusViewModel itemSelected = View.GetSelectedItem();

            if (itemSelected != null)
            {
                MaritalStatusViewModel modifiedMaritalStatus = View.ShowModifyMaritalStatusForm(itemSelected);

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

                    View.SetGridData(listMaritalStatuses);
                }
            }
        }

        public void DeleteMaritalStatus()
        {
            ListItemMaritalStatusViewModel itemSelected = View.GetSelectedItem();

            if (itemSelected != null)
            {
                bool delete = View.ShowDeleteMaritalStatusDialog(itemSelected);

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

                    View.SetGridData(maritalStatuses);
                }
            }
        }
    }
}
