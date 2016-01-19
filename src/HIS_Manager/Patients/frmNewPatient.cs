using CIS.Data.DataAccess;
using CIS.Presentation.Logic.Presenter.Patients;
using CIS.Presentation.Model.Common;
using CIS.Presentation.Model.Patients;
using CIS.Presentation.UI.Contracts.Patients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace CIS.Presentation.UI.WindowsForms
{
    public partial class frmNewPatient : Form, INewPatientView
    {
        private NewPatientPresenter _presenter;

        public frmNewPatient()
        {
            InitializeComponent();
            _presenter = new NewPatientPresenter(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _presenter.Save();
            }
            catch (Exception ex)
            {
                throw;
            }

            MessageBox.Show("New Patient Registered");

            Close();
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (txtLastName.Text.Trim().Length != 0 && txtLastName.Text.Any(c => !char.IsLetter(c)))
            {
                e.Cancel = true;
                MessageBox.Show("Mandatory Field is empty: Lastname");
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (txtLastName.Text.Trim().Length > 0 && txtLastName.Text.Any(c => !char.IsLetter(c)))
            {
                e.Cancel = true;
                MessageBox.Show("Mandatory Field is empty: Firstname");
            }
        }

        private void cboGender_Validating(object sender, CancelEventArgs e)
        {
            if (cboGender.SelectedIndex > 0)
            {
                e.Cancel = true;
                MessageBox.Show("Mandatory Field is empty: Gender");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public NewPatientViewModel GetFormData()
        {
            return new NewPatientViewModel
            {
                HospitalNumber = mtbHospitalId.Text,
                Title = Convert.ToInt32(cboTitle.SelectedValue),
                LastName = txtLastName.Text,
                FirstName = txtFirstName.Text,
                OtherName = txtMname.Text,
                Gender = Convert.ToInt32(cboTitle.SelectedValue),
                BirthDate = dtpBirthDate.Value,
                Phone = mtbPhone.Text,
                HomeAddress = txtHomeAdd.Text,
                MaritalStatus = Convert.ToInt32(cboMaritalStatus.SelectedValue)
            };
        }

        private void frmNewPatient_Load(object sender, EventArgs e)
        {
            _presenter.LoadTitles();
            _presenter.LoadGenres();
            _presenter.LoadMaritalStatuses();
        }

        public void LoadTitles(IEnumerable<ComboTitleViewModel> titles)
        {
            cboTitle.DataSource = titles.ToList();
            cboTitle.DisplayMember = "Description";
            cboTitle.ValueMember = "Identifier";
        }


        public void LoadGenres(IEnumerable<ComboGenreViewModel> genres)
        {
            cboGender.DataSource = genres.ToList();
            cboGender.DisplayMember = "Description";
            cboGender.ValueMember = "Identifier";
        }

        public void LoadMaritalStatuses(IEnumerable<ComboMaritalStatusViewModel> maritalStatuses)
        {
            cboMaritalStatus.DataSource = maritalStatuses.ToList();
            cboMaritalStatus.DisplayMember = "Description";
            cboMaritalStatus.ValueMember = "Identifier";
        }
    }
}
