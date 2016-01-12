using CIS.Presentation.Models.Administration;

namespace CIS.Presentation.UI.Contracts.Administration
{
    public interface IChangeUserPasswordView
    {
        ChangeUserPasswordViewModel GetFormData();
    }
}
