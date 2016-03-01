using CIS.Presentation.Logic.Presenter.Administration;
using CIS.Presentation.Model.Clinicians;
using CIS.Presentation.Model.Common;
using CIS.Presentation.UI.Contracts.Administration;
using System;
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

        public void LoadClinicians(IEnumerable<ClinicListViewModel> clinicians)
        {
            dgvClinicians.DataSource = clinicians;
        }

        public EditClinicViewModel GetClinic()
        {
            if (dgvClinicians.SelectedColumns.Count > 0)
            {
                return dgvClinicians.SelectedRows[0].Tag as EditClinicViewModel;
            }
            else
            {
                return null;
            }
        }

        public void ShowEditClinicForm(EditClinicViewModel clinic)
        {
            frmEditClinic frm = new frmEditClinic(clinic);
            frm.ShowDialog();
        }
    }
}
