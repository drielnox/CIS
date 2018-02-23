using CIS.Presentation.Model.Administration.Title;
using CIS.Presentation.UI.Contracts.Administration.Configuration.Title;
using CIS.Transversal.SharedKernel.Patterns.MVP;

namespace CIS.Presentation.Logic.Presenter.Administration.Configuration.Title
{
    public class ModifyTitlePresenter : Presenter<IModifyTitleView>
    {
        public ModifyTitlePresenter(IModifyTitleView view) : base(view)
        {
        }

        public void LoadTitle()
        {
            TitleViewModel model = View.GetCurrentTitle();
            View.SetIdentifier(model.Identifier);
            View.SetAbbreviation(model.Abbreviation);
            View.SetDescription(model.Description);
        }

        public void EnableAccept()
        {
            TitleViewModel model = View.GetCurrentTitle();
            string currentAbbr = View.GetAbbreviation();
            string currentDesc = View.GetDescription();
            bool enable = model.Abbreviation.CompareTo(currentAbbr) == 0 || model.Description.CompareTo(currentDesc) == 0;
            View.EnableAcceptButton(enable);
        }

        public void Accept()
        {
            int id = View.GetIdentifier();
            string abbr = View.GetAbbreviation();
            string desc = View.GetDescription();
            TitleViewModel model = new TitleViewModel
            {
                Identifier = id,
                Abbreviation = abbr,
                Description = desc
            };
            View.SetTag(model);
        }
    }
}
