using CIS.Presentation.UI.Contracts.Administration.Configuration.Title;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIS.Presentation.Logic.Presenter.Administration.Configuration.Title
{
    public class ViewTitlesPresenter
    {
        private IViewTitlesView _view;

        public ViewTitlesPresenter(IViewTitlesView view)
        {
            _view = view;
        }
    }
}
