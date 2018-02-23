using CIS.Presentation.Model.Administration.Title;
using CIS.Transversal.SharedKernel.Patterns.MVP;

namespace CIS.Presentation.UI.Contracts.Administration.Configuration.Title
{
    public interface IModifyTitleView : IView
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
