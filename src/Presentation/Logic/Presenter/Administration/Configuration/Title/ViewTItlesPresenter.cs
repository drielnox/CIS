using CIS.Application.Service.Contract;
using CIS.Presentation.Model.Administration.Title;
using CIS.Presentation.Model.Common;
using CIS.Presentation.UI.Contracts.Administration.Configuration.Title;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace CIS.Presentation.Logic.Presenter.Administration.Configuration.Title
{
    public class ViewTitlesPresenter
    {
        private IViewTitlesView _view;

        private ChannelFactory<IConfigurationContract> channel;

        public ViewTitlesPresenter(IViewTitlesView view)
        {
            _view = view;

            channel = new ChannelFactory<IConfigurationContract>("ConfigurationEndPoint");
        }

        public void SetInitialControlProperties()
        {
            _view.SetInitialGridProperties();
        }

        public void LoadTitles()
        {
            IEnumerable<ListItemTitleViewModel> listData;

            using (var proxy = channel.CreateChannel())
            {
                listData = proxy.GetTitles();
            }

            _view.SetListData(listData);
        }

        public void AddNewTitle()
        {
            TitleViewModel newTitle = _view.ShowNewTitleForm();

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

                _view.SetListData(newListData);
            }
        }

        public void ModifyTitle()
        {
            ListItemTitleViewModel itemSelected = _view.GetSelectedTitle();

            if (itemSelected != null)
            {
                TitleViewModel modifiedTitle = _view.ShowModifyTitleForm(itemSelected);

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

                    _view.SetListData(newListData);
                }
            }
        }

        public void DeleteTitle()
        {
            throw new NotImplementedException();
        }
    }
}
