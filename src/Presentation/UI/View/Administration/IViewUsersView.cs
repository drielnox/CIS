using CIS.Presentation.Model.Administration;

namespace CIS.Presentation.UI.Contracts.Administration
{
    public interface IViewUsersView
    {
        NewUserViewModel ShowAddUserDialog();

        void RefreshUserList();

        UserViewModel GetSelectedUser();

        void ShowChangeUserPasswordDialog(UserViewModel user);
        
        void LoadUserList(UsersViewModel users);
    }
}
