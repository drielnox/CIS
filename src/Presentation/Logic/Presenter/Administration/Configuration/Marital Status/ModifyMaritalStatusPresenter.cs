using CIS.Presentation.Model.Administration.MaritalStatus;
using CIS.Presentation.UI.Contracts.Administration.Configuration.MaritalStatus;

namespace CIS.Presentation.Logic.Presenter.Administration.Configuration.MaritalStatus
{
    public class ModifyMaritalStatusPresenter
    {
        private IModifyMaritalStatusView _view;

        public ModifyMaritalStatusPresenter(IModifyMaritalStatusView view)
        {
            _view = view;
        }

        public void LoadTitle()
        {
            MaritalStatusViewModel model = _view.GetCurrentMaritalStatus();
            _view.SetIdentifier(model.Identifier);
            _view.SetAbbreviation(model.Abbreviation);
            _view.SetDescription(model.Description);
        }

        public void EnableAccept()
        {
            MaritalStatusViewModel model = _view.GetCurrentMaritalStatus();
            string abbr = _view.GetAbbreviation();
            string desc = _view.GetDescription();
            bool enable = model.Abbreviation.CompareTo(abbr) == 0 || model.Description.CompareTo(desc) == 0;
            _view.EnableAcceptButton(enable);
        }

        public void Accept()
        {
            int id = _view.GetIdentifier();
            string abbr = _view.GetAbbreviation();
            string desc = _view.GetDescription();
            MaritalStatusViewModel model = new MaritalStatusViewModel
            {
                Identifier = id,
                Abbreviation = abbr,
                Description = desc
            };
            _view.SetTag(model);
        }
    }
}
