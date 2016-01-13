using CIS.Presentation.Model.Administration;

namespace CIS.Presentation.UI.Contracts.Administration
{
    public interface IChangeUserPasswordView
    {
        ChangeUserPasswordViewModel GetFormData();
    }
}
