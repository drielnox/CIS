using CIS.Presentation.Model.Administration;
using CIS.Transversal.SharedKernel.Patterns.MVP;

namespace CIS.Presentation.UI.Contracts.Administration
{
    public interface INewUserView : IView
    {
        NewUserViewModel GetUserData();
    }
}
