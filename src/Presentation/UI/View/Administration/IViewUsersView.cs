using CIS.Presentation.Models.Administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
