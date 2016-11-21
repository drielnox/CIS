using CIS.Presentation.Model.Administration.Title;
using CIS.Presentation.UI.Contracts.Administration.Configuration.Title;
using CIS.Transversal.SharedKernel.Patterns.MVP;

namespace CIS.Presentation.Logic.Presenter.Administration.Configuration.Title
{
    public class NewTitlePresenter : Presenter<INewTitleView>
    {
        public NewTitlePresenter(INewTitleView view) : base(view)
        {

        }

        public void Accept()
        {
            string abbreviation = View.GetAbbreviation();
            string description = View.GetDescription();
            TitleViewModel model = new TitleViewModel
            {
                Abbreviation = abbreviation,
                Description = description
            };
            View.SetFormTag(model);
        }
    }
}
