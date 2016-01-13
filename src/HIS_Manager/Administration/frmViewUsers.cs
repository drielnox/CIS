using CIS.Data.DataAccess;
using CIS.Presentation.Logic.Presenter.Administration;
using CIS.Presentation.Model.Administration;
using CIS.Presentation.UI.Contracts.Administration;
using System;
using System.Windows.Forms;

namespace CIS.Presentation.UI.WindowsForms
{
    public partial class frmViewUsers : Form, IViewUsersView
    {
        private ViewUsersPresenter _presenter;

        public frmViewUsers()
        {
            InitializeComponent();
            _presenter = new ViewUsersPresenter(this);
        }

        private void frmViewUsers_Load(object sender, EventArgs e)
        {
            _presenter.LoadUserList();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            _presenter.ChangeUserPassword();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            _presenter.AddUser();
        }

        public NewUserViewModel ShowAddUserDialog()
        {
            frmNewUser newUser = new frmNewUser();
            newUser.ShowDialog();
            return newUser.Tag as NewUserViewModel;
        }

        public void RefreshUserList()
        {
            Refresh();
        }

        public UserViewModel GetSelectedUser()
        {
            if (lvUsers.SelectedItems.Count > 0)
            {
                var item = lvUsers.SelectedItems[0];
                return item.Tag as UserViewModel;
            }

            return null;
        }

        public void ShowChangeUserPasswordDialog(UserViewModel user)
        {
            frmChangeUserPassword frm = new frmChangeUserPassword(user);
            frm.ShowDialog();
        }

        public void LoadUserList(UsersViewModel users)
        {
            foreach (var user in users.UserList)
            {
                AddAUserToListView(user);
            }
        }

        private void AddAUserToListView(UserViewModel user)
        {
            var listItem = new ListViewItem(new string[]
                {
                    user.StaffId,
                    user.Username,
                    user.FirstName,
                    user.LastName,
                    user.Profile
                });

            lvUsers.Items.Add(listItem);
        }
    }
}
