using CIS.Presentation.Logic.Presenter.Patients;
using CIS.Presentation.Model.Patients;
using CIS.Presentation.UI.Contracts.Patients;
using System;
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgvPatients.SelectedRows[0];
                frmPatientRecord frm = new frmPatientRecord(dr);
                frm.Show();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvPatients.SelectedRows[0];
            frmPatientRecord frm = new frmPatientRecord(dr);
            frm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _presenter.SearchPatient();
        }

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

        private void lvPatients_DoubleClick(object sender, EventArgs e)
        {
            _presenter.ShowPatientData();
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
    }
}
