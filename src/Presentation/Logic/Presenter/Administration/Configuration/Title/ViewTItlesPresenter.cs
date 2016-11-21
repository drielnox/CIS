using CIS.Application.Service.Contract;
using CIS.Presentation.Model.Administration.Title;
using CIS.Presentation.UI.Contracts.Administration.Configuration.Title;
using CIS.Transversal.SharedKernel.Patterns.MVP;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace CIS.Presentation.Logic.Presenter.Administration.Configuration.Title
{
    public class ViewTitlesPresenter : Presenter<IViewTitlesView>
    {
        private ChannelFactory<IConfigurationContract> channel;

        public ViewTitlesPresenter(IViewTitlesView view) : base(view)
        {
            channel = new ChannelFactory<IConfigurationContract>("ConfigurationEndPoint");
        }

        public void SetInitialControlProperties()
        {
            View.SetInitialGridProperties();
        }

        public void LoadTitles()
        {
            IEnumerable<ListItemTitleViewModel> listData;

            using (var proxy = channel.CreateChannel())
            {
                listData = proxy.GetTitles();
            }

            View.SetGridData(listData);
        }

        public void AddNewTitle()
        {
            TitleViewModel newTitle = View.ShowNewTitleForm();

            if (newTitle != null)
            {
                IEnumerable<ListItemTitleViewModel> newListData;

                try
                {
                    using (var proxy = channel.CreateChannel())
                    {
                        proxy.AddTitle(newTitle);
                        newListData = proxy.GetTitles();
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }

                View.SetGridData(newListData);
            }
        }

        public void ModifyTitle()
        {
            ListItemTitleViewModel itemSelected = View.GetSelectedTitle();

            if (itemSelected != null)
            {
                TitleViewModel modifiedTitle = View.ShowModifyTitleForm(itemSelected);

                if (modifiedTitle != null)
                {
                    IEnumerable<ListItemTitleViewModel> newListData;

                    try
                    {
                        using (var proxy = channel.CreateChannel())
                        {
                            proxy.ModifyTitle(modifiedTitle);
                            newListData = proxy.GetTitles();
                        }
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }

                    View.SetGridData(newListData);
                }
            }
        }

        public void DeleteTitle()
        {
            ListItemTitleViewModel itemSelected = View.GetSelectedTitle();

            if (itemSelected != null)
            {
                bool delete = View.ShowDeleteTitleDialog(itemSelected);

                if (delete)
                {
                    IEnumerable<ListItemTitleViewModel> newListData;

                    try
                    {
                        using (var proxy = channel.CreateChannel())
                        {
                            proxy.DeleteTitle(itemSelected);
                            newListData = proxy.GetTitles();
                        }
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }

                    View.SetGridData(newListData);
                }
            }
        }
    }
}
