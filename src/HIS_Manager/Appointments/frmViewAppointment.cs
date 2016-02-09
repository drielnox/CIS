using CIS.Presentation.Logic.Presenter.Appointment;
using CIS.Presentation.Model.Appointment;
using CIS.Presentation.UI.Contracts.Appointment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CIS.Presentation.UI.WindowsForms
{
    public partial class frmViewAppointment : Form, IViewAppointmentView
    {
        private ViewAppointmentPresenter _presenter;

        public frmViewAppointment()
        {
            InitializeComponent();
            _presenter = new ViewAppointmentPresenter(this);
        }

        private void frmViewAppointment_Load(object sender, EventArgs e)
        {
            _presenter.LoadAppointments();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            _presenter.ApplyFilter();
        }

        public void LoadAppointments(IEnumerable<ViewAppointmentViewModel> ap)
        {
            dgvAppointment.DataSource = ap.ToList();
        }

        public IEnumerable<ViewAppointmentFilterViewModel> GetFilters()
        {
            var patientId = txtPatientId.Text;
            var date = dtpAppointmentDate.Checked ? dtpAppointmentDate.Value.ToString() : DateTime.Now.ToString();
            var clinicianId = txtConsultant.Text;

            return new List<ViewAppointmentFilterViewModel>
            {
                new ViewAppointmentFilterViewModel
                {
                    Key = "PatientId",
                    Value = patientId
                },
                new ViewAppointmentFilterViewModel
                {
                    Key = "Date",
                    Value = date
                },
                new ViewAppointmentFilterViewModel
                {
                    Key = "ClinicianId",
                    Value = clinicianId
                },
            };
        }

        public void SetFilters(IEnumerable<ViewAppointmentFilterViewModel> filters)
        {
            foreach (var item in filters)
            {
                
            }
        }
    }
}
