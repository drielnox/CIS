using CIS.Data.DataAccess;
using CIS.Presentation.Logic.Presenter;
using CIS.Presentation.Models;
using CIS.Presentation.UI.Contracts;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CIS.Presentation.UI.WindowsForms
{
    public partial class frmNewClinic : Form, INewClinicView
    {
        private readonly NewClinicPresenter _presenter;

        public frmNewClinic()
        {
            InitializeComponent();
            _presenter = new NewClinicPresenter(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NewClinicPresentationModel clinic = _presenter.GetClinicianData();
            _presenter.Save(clinic);

            MessageBox.Show("Clinic Saved");

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtClinicNumber_Validating(object sender, CancelEventArgs e)
        {
            if (_presenter.ValidateClinicNumber(txtClinicNumber.Text))
            {
                e.Cancel = true;
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (_presenter.ValidateLastName(txtLastName.Text))
            {
                e.Cancel = true;
            }
        }

        public void LoadTitles()
        {
            throw new NotImplementedException();
        }

        public NewClinicPresentationModel GetClinicianData()
        {
            return new NewClinicPresentationModel()
            {
                InternalCode = txtClinicNumber.Text,
                Title = (int)cboTitle.SelectedValue,
                LastName = txtLastName.Text,
                FirstName = txtFirstName.Text,
                Specialty = txtSpecialty.Text,
                Department = txtDepartment.Text,
                Address = txtAddress.Text,
                Telephone = txtTelephone.Text,
                Email = txtEmail.Text
            };
        }
    }
}
