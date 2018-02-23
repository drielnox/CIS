using CIS.Presentation.Model.Administration.MaritalStatus;
using CIS.Presentation.UI.Contracts.Administration.Configuration.MaritalStatus;
using CIS.Transversal.SharedKernel.Patterns.MVP;

namespace CIS.Presentation.Logic.Presenter.Administration.Configuration.MaritalStatus
{
    public class ModifyMaritalStatusPresenter : Presenter<IModifyMaritalStatusView>
    {
        public ModifyMaritalStatusPresenter(IModifyMaritalStatusView view) : base(view)
        {
        }

        public void LoadTitle()
        {
            MaritalStatusViewModel model = View.GetCurrentMaritalStatus();
            View.SetIdentifier(model.Identifier);
            View.SetAbbreviation(model.Abbreviation);
            View.SetDescription(model.Description);
        }

        public void EnableAccept()
        {
            MaritalStatusViewModel model = View.GetCurrentMaritalStatus();
            string abbr = View.GetAbbreviation();
            string desc = View.GetDescription();
            bool enable = model.Abbreviation.CompareTo(abbr) == 0 || model.Description.CompareTo(desc) == 0;
            View.EnableAcceptButton(enable);
        }

        public void Accept()
        {
            int id = View.GetIdentifier();
            string abbr = View.GetAbbreviation();
            string desc = View.GetDescription();
            MaritalStatusViewModel model = new MaritalStatusViewModel
            {
                Identifier = id,
                Abbreviation = abbr,
                Description = desc
            };
            View.SetTag(model);
        }
    }
}
