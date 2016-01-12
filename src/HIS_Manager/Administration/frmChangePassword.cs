using CIS.Presentation.Logic.Presenter.Administration;
using CIS.Presentation.Models.Administration;
using CIS.Presentation.UI.Contracts.Administration;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CIS.Presentation.UI.WindowsForms
{
    public partial class frmChangeUserPassword : Form, IChangeUserPasswordView
    {
        private ChangeUserPasswordPresenter _presenter;
        private UserViewModel _user;

        public frmChangeUserPassword()
        {
            InitializeComponent();
            _presenter = new ChangeUserPasswordPresenter(this);
        }

        public frmChangeUserPassword(UserViewModel user)
            : this()
        {
            this._user = user;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_presenter.PasswordsAreEquals(txtPassword.Text, txtConfirmPassword.Text))
            {
                MessageBox.Show("Please confirm Password and Confirm Pasword fields match");
                txtPassword.Text = string.Empty;
                txtConfirmPassword.Text = string.Empty;
                return;
            }

            _presenter.Save();

            MessageBox.Show("Password changed successfully");

            Close();
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (_presenter.ValidatePassword(txtPassword.Text))
            {
                e.Cancel = true;
            }
        }

        private void txtPassConfirm_Validating(object sender, CancelEventArgs e)
        {
            if (_presenter.ValidatePassword(txtConfirmPassword.Text))
            {
                e.Cancel = true;
            }
        }

        public ChangeUserPasswordViewModel GetFormData()
        {
            return new ChangeUserPasswordViewModel
            {
                ConfirmPassword = txtConfirmPassword.Text,
                Password = txtPassword.Text,
                UserId = _user.StaffId
            };
        }
    }
}
