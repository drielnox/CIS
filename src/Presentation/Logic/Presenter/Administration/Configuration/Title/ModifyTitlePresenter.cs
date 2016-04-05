using CIS.Presentation.Model.Administration.Title;
using CIS.Presentation.UI.Contracts.Administration.Configuration.Title;

namespace CIS.Presentation.Logic.Presenter.Administration.Configuration.Title
{
    public class ModifyTitlePresenter
    {
        private IModifyTitleView _view;

        public ModifyTitlePresenter(IModifyTitleView view)
        {
            _view = view;
        }

        public void LoadTitle()
        {
            TitleViewModel model = _view.GetCurrentTitle();
            _view.SetIdentifier(model.Identifier);
            _view.SetAbbreviation(model.Abbreviation);
            _view.SetDescription(model.Description);
        }

        public void EnableAccept()
        {
            TitleViewModel model = _view.GetCurrentTitle();
            string currentAbbr = _view.GetAbbreviation();
            string currentDesc = _view.GetDescription();
            bool enable = model.Abbreviation.CompareTo(currentAbbr) == 0 || model.Description.CompareTo(currentDesc) == 0;
            _view.EnableAcceptButton(enable);
        }

        public void Accept()
        {
            int id = _view.GetIdentifier();
            string abbr = _view.GetAbbreviation();
            string desc = _view.GetDescription();
            TitleViewModel model = new TitleViewModel
            {
                Identifier = id,
                Abbreviation = abbr,
                Description = desc
            };
            _view.SetTag(model);
        }
    }
}
