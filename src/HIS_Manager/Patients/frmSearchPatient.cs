using CIS.Presentation.Logic.Presenter.Patients;
using CIS.Presentation.Model.Patients;
using CIS.Presentation.UI.Contracts.Patients;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CIS.Presentation.UI.WindowsForms
{
    public partial class frmSearchPatient : Form, ISearchPatientView
    {
        private SearchPatientPresenter _presenter;

        public frmSearchPatient()
        {
            InitializeComponent();
            _presenter = new SearchPatientPresenter(this);
        }

        #region Form Events

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count > 0)
            {
                var dr = dgvPatients.SelectedRows[0].Tag as EditPatientViewModel;
                frmEditPatient frm = new frmEditPatient(dr);
                frm.Show();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            var dr = dgvPatients.SelectedRows[0].Tag as EditPatientViewModel;
            frmEditPatient frm = new frmEditPatient(dr);
            frm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _presenter.ValidateSearchFields();
            _presenter.SearchPatient();
        }

        private void lvPatients_DoubleClick(object sender, EventArgs e)
        {
            _presenter.ShowPatientData();
        }

        #region Validations

        private void txtPatientId_Validating(object sender, CancelEventArgs e)
        {
            if (_presenter.ValidatePatientId())
            {
                e.Cancel = true;
            }
        }

        private void txtHospitalNumber_Validating(object sender, CancelEventArgs e)
        {
            if (_presenter.ValidateHospitalNumber())
            {
                e.Cancel = true;
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (_presenter.ValidateLastName())
            {
                e.Cancel = true;
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (_presenter.ValidateFirstName())
            {
                e.Cancel = true;
            }
        }

        #endregion

        public bool RequestValidatePatientId()
        {
            return true;
        }

        #endregion

        #region Private Methods

        private void AddPatientToGrid(PatientViewModel patient)
        {
            var listItem = new ListViewItem(new string[]
                {
                    patient.Identifier,
                    patient.FirstName,
                    patient.LastName
                });
            listItem.Tag = patient;

            lvPatients.Items.Add(listItem);
        }

        #endregion

        public SearchPatientViewModel GetSearchCriteria()
        {
            return new SearchPatientViewModel
            {
                PatientId = txtPatientId.Text,
                HospitalNumber = txtHospitalNumber.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text
            };
        }

        public void ShowSearchResult(PatientsViewModel patients)
        {
            foreach (PatientViewModel patient in patients.Patients)
            {
                AddPatientToGrid(patient);
            }
        }

        public PatientViewModel GetSelectedPatient()
        {
            if (lvPatients.SelectedItems.Count > 0)
            {
                var item = lvPatients.SelectedItems[0];
                return item.Tag as PatientViewModel;
            }

            return null;
        }

        public string GetPatientId()
        {
            return txtPatientId.Text;
        }

        public string GetHospitalNumber()
        {
            return txtHospitalNumber.Text;
        }

        public string GetLastName()
        {
            return txtLastName.Text;
        }

        public string GetFirstName()
        {
            return txtFirstName.Text;
        }


    }
}
