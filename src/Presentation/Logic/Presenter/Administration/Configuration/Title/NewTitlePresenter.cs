using CIS.Presentation.Model.Administration.Title;
using CIS.Presentation.UI.Contracts.Administration.Configuration.Title;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIS.Presentation.Logic.Presenter.Administration.Configuration.Title
{
    public class NewTitlePresenter
    {
        private INewTitleView _view;

        public NewTitlePresenter(INewTitleView view)
        {
            _view = view;
        }

        public void Accept()
        {
            string abbreviation = _view.GetAbbreviation();
            string description = _view.GetDescription();
            TitleViewModel model = new TitleViewModel
            {
                Abbreviation = abbreviation,
                Description = description
            };
            _view.SetFormTag(model);
        }
    }
}
