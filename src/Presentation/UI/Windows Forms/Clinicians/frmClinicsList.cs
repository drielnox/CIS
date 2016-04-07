using CIS.Presentation.Logic.Presenter.Administration;
using CIS.Presentation.Model.Clinicians;
using CIS.Presentation.Model.Common;
using CIS.Presentation.UI.Contracts.Administration;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CIS.Presentation.UI.WindowsForms
{
    public partial class frmClinicsList : Form, IViewCliniciansView
    {
        private ViewCliniciansPresenter _presenter;

        public frmClinicsList()
        {
            InitializeComponent();
            _presenter = new ViewCliniciansPresenter(this);
        }

        #region Form Events

        private void frmClinicsList_Load(object sender, EventArgs e)
        {
            _presenter.SetInitialControlSettings();
            _presenter.LoadClinics();
        }

        private void btnNewC_Click(object sender, EventArgs e)
        {
            frmNewClinic frm = new frmNewClinic();
            frm.ShowDialog();
        }

        private void btnEditC_Click(object sender, EventArgs e)
        {
            _presenter.ShowEditClinic();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBookAppt_Click(object sender, EventArgs e)
        {
            frmBookAppointment frm = new frmBookAppointment();
            frm.ShowDialog();
        }

        #endregion

        public void SetGridInitialSettings()
        {
            dgvClinicians.AutoGenerateColumns = true;
        }

        public void LoadClinicians(IEnumerable<ClinicListViewModel> clinicians)
        {
            bsClinicians.DataSource = clinicians.ToList();
        }

        public ClinicListViewModel GetSelectedClinic()
        {
            return dgvClinicians.SelectedRows.Count > 0
                ? bsClinicians.Current as ClinicListViewModel
                : null;
        }

        public void ShowEditClinicForm(EditClinicViewModel clinic)
        {
            frmEditClinic frm = new frmEditClinic(clinic);
            frm.ShowDialog();
        }
    }
}
