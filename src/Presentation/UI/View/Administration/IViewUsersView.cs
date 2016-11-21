using CIS.Presentation.Model.Administration;
using CIS.Transversal.SharedKernel.Patterns.MVP;

namespace CIS.Presentation.UI.Contracts.Administration
{
    public interface IViewUsersView : IView
    {
        NewUserViewModel ShowAddUserDialog();

        void RefreshUserList();

        UserViewModel GetSelectedUser();

        void ShowChangeUserPasswordDialog(UserViewModel user);

        void LoadUserList(UsersViewModel users);
    }
}
