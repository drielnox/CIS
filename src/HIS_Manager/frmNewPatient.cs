using CIS.Data.DataAccess;
using CIS.Presentation.Logic.Presenter.Patients;
using CIS.Presentation.Model.Patients;
using CIS.Presentation.UI.Contracts.Patients;
using System;
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

            var patient = new Patient
            {
                HospitalNumber = int.Parse(mtbHospitalId.Text),
                Title = (Title)Enum.Parse(typeof(Title), cboTitle.Text),
                LastName = txtLastName.Text,
                FirstName = txtFirstName.Text,
                OtherName = txtMname.Text,
                Gender = (Gender)Enum.Parse(typeof(Gender), cboTitle.Text),
                BirthDate = dtpBirthDate.Value,
                Phone = int.Parse(mtbPhone.Text),
                HomeAddress = txtHomeAdd.Text,
                MaritalStatus = (MaritalStatus)Enum.Parse(typeof(MaritalStatus), cboMaritalStatus.Text)
            };

            using (ClinicModel model = new ClinicModel())
            {
                model.Patients.Add(patient);
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
                HospitalNumber = int.Parse(mtbHospitalId.Text),
                Title = (Title)Enum.Parse(typeof(Title), cboTitle.Text),
                LastName = txtLastName.Text,
                FirstName = txtFirstName.Text,
                OtherName = txtMname.Text,
                Gender = (Gender)Enum.Parse(typeof(Gender), cboTitle.Text),
                BirthDate = dtpBirthDate.Value,
                Phone = int.Parse(mtbPhone.Text),
                HomeAddress = txtHomeAdd.Text,
                MaritalStatus = (MaritalStatus)Enum.Parse(typeof(MaritalStatus), cboMaritalStatus.Text)
            };
        }

        private void frmNewPatient_Load(object sender, EventArgs e)
        {
            _presenter.LoadTitles();
            _presenter.LoadGenres();
            _presenter.LoadMaritalStatuses();
        }
    }
}
