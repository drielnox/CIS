using CIS.Presentation.Logic.Presenter.Administration;
using CIS.Presentation.Models.Administration;
using CIS.Presentation.UI.Contracts.Administration;
using System;
using System.Windows.Forms;

namespace CIS.Presentation.UI.WindowsForms
{
    public partial class frmNewUser : Form, INewUserView
    {
        private NewUserPresenter _presenter;

        public frmNewUser()
        {
            InitializeComponent();
            _presenter = new NewUserPresenter(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _presenter.SaveUser();

            MessageBox.Show("New User Created");

            Close();
        }

        public NewUserViewModel GetUserData()
        {
            return new Models.Administration.NewUserViewModel
            {
                StaffId = txtStaffId.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Password = txtPassword.Text,
                Profile = txtProfile.Text,
                UserName = txtUsername.Text
            };
        }
    }
}
