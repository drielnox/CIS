using CIS.Presentation.Model.Administration.Title;
using CIS.Transversal.SharedKernel.Patterns.MVP;

namespace CIS.Presentation.UI.Contracts.Administration.Configuration.Title
{
    public interface INewTitleView : IView
    {
        string GetAbbreviation();

        string GetDescription();

        void SetFormTag(TitleViewModel model);
    }
}
