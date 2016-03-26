using CIS.Presentation.UI.Contracts.Administration.Configuration.Title;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIS.Presentation.Logic.Presenter.Administration.Configuration.Title
{
    public class ModifyTitlePresenter
    {
        private IModifyTitleView _view;

        public ModifyTitlePresenter(IModifyTitleView view)
        {
            _view = view;
        }
    }
}
