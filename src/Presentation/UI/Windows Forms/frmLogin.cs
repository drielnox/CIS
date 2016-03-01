using CIS.Presentation.Logic.Presenter;
using CIS.Presentation.Model;
using CIS.Presentation.UI.Contracts;
using System;
using System.Windows.Forms;

namespace CIS.Presentation.UI.WindowsForms
{
    public partial class frmLogin : Form, ILoginView
    {
        private LoginPresenter _preseneter;

        public frmLogin()
        {
            InitializeComponent();
            _preseneter = new LoginPresenter(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                _preseneter.Login();
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        public LoginViewModel GetFormData()
        {
            return new LoginViewModel 
            {
                Password = txtPassword.Text,
                Username = txtUsername.Text
            };
        }

        private void txtUsername_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!_preseneter.ValidateUsername(txtUsername.Text))
            {
                e.Cancel = true;
            }
        }

        private void txtUsername_Validated(object sender, EventArgs e)
        {

        }

        private void txtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!_preseneter.ValidatePassword(txtPassword.Text))
            {
                e.Cancel = true;
            }
        }

        private void txtPassword_Validated(object sender, EventArgs e)
        {

        }
    }
}
