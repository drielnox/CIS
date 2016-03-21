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

        public void LoadTitles()
        {
            IEnumerable<ListItemTitleViewModel> comboData;

            using(var proxy = channel.CreateChannel())
            {
                comboData = proxy.GetTitles();
            }

            _view.SetListData(comboData);
        }
    }
}
