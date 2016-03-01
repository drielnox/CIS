using CIS.Presentation.Logic.Presenter.Appointment;
using CIS.Presentation.Model.Appointment;
using CIS.Presentation.Model.Common;
using CIS.Presentation.UI.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CIS.Presentation.UI.WindowsForms
{
    public partial class frmBookAppointment : Form, IBookAppointmentView
    {
        private BookAppointmentPresenter _presenter;

        public frmBookAppointment()
        {
            InitializeComponent();
            _presenter = new BookAppointmentPresenter(this);
        }

        #region Form Events

        private void frmBookAppointment_Load(object sender, EventArgs e)
        {
            _presenter.LoadClinicians();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _presenter.Save();

            MessageBox.Show("Clinic Saved");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLoadClinic_Click(object sender, EventArgs e)
        {
            if (dgridClinics.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgridClinics.SelectedRows[0];
                txtConsultant.Text = dr.Cells[0].Value.ToString() + " " + dr.Cells[2].Value.ToString();
                txtClinicianNumber.Text = dr.Cells[2].Value.ToString();
            }
        }

        private void dgridClinics_DoubleClick_1(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgridClinics.SelectedRows[0];
            txtConsultant.Text = dr.Cells[0].Value.ToString() + " " + dr.Cells[2].Value.ToString();
            txtClinicianNumber.Text = dr.Cells[2].Value.ToString();
            grpClinics.Visible = false;
        }

        private void txtPid_Leave(object sender, EventArgs e)
        {
            _presenter.LoadPatient();
        }

        private void txtPatientId_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_presenter.ValidatePatientId())
            {
                e.Cancel = true;
            }
        }

        private void txtPatConsultant_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConsultant.Text))
            {
                e.Cancel = true;
            }
        }

        private void txtCNum_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtClinicianNumber.Text.Any(c => !char.IsNumber(c)))
            {
                e.Cancel = true;
            }
        }

        private void txtPatname_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPatientName.Text))
            {
                e.Cancel = true;
            }
        }

        #endregion

        public BookAppointmentViewModel GetAppointment()
        {
            return new BookAppointmentViewModel()
            {
                Identifier = int.Parse(txtClinicianNumber.Text),
                ClinicianName = txtConsultant.Text,
                PatientId = int.Parse(txtPatientId.Text),
                HospitalNumber = int.Parse(txtHospitalNumber.Text),
                PatientName = txtPatientName.Text,
                Created = dtpCreationDate.Value,
                Purpose = txtPurpose.Text,
                CreatedAt = DateTime.Now
            };
        }

        public void LoadClinicians(IEnumerable<ClinicListViewModel> clinicians)
        {
            dgridClinics.DataSource = clinicians.ToList();
        }

        public string GetPatientId()
        {
            return txtPatientId.Text;
        }

        public void SetPatientForBookAppointment(PatientOfBookAppointmentViewModel patient)
        {
            txtPatientName.Text = patient.FirstName + " " + patient.LastName;
            txtHospitalNumber.Text = patient.HospitalNumber;
        }
    }
}
