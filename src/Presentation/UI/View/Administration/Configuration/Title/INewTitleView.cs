using CIS.Presentation.Model.Administration.Title;

namespace CIS.Presentation.UI.Contracts.Administration.Configuration.Title
{
    public interface INewTitleView
    {
        string GetAbbreviation();

        string GetDescription();

        void SetFormTag(TitleViewModel model);
    }
}
