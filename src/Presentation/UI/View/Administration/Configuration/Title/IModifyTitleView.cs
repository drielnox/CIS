using CIS.Presentation.Model.Administration.Title;

namespace CIS.Presentation.UI.Contracts.Administration.Configuration.Title
{
    public interface IModifyTitleView
    {
        TitleViewModel GetCurrentTitle();

        void SetIdentifier(int p);

        void SetAbbreviation(string p);

        void SetDescription(string p);

        void EnableAcceptButton(bool enable);

        int GetIdentifier();

        string GetAbbreviation();

        string GetDescription();

        void SetTag(TitleViewModel model);
    }
}
