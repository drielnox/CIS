using CIS.Presentation.Logic.Presenter.Administration.Configuration.MaritalStatus;
using CIS.Presentation.Model.Administration.MaritalStatus;
using CIS.Presentation.UI.Contracts.Administration.Configuration.MaritalStatus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CIS.Presentation.UI.WindowsForms.Administration.Configuration.MaritalStatus
{
    public partial class frmViewMaritalStatus : Form, IViewMaritalStatusesView
    {
        private ViewMaritalStatusesPresenter _presenter;

        public frmViewMaritalStatus()
        {
            InitializeComponent();

            _presenter = new ViewMaritalStatusesPresenter(this);
        }

        #region IViewMaritalStatusesView

        public void SetInitalGridProperties()
        {
            dgvMaritalStatuses.AutoGenerateColumns = true;
        }

        public void SetGridData(IEnumerable<ListItemMaritalStatusViewModel> listMaritalStatuses)
        {
            bsMaritalStatuses.DataSource = listMaritalStatuses.ToList();
        }

        public MaritalStatusViewModel ShowNewMaritalStatusForm()
        {
            frmNewMaritalStatus frm = new frmNewMaritalStatus();
            return frm.ShowDialog(this) == DialogResult.OK
                ? frm.Tag as MaritalStatusViewModel
                : null;
        }

        public ListItemMaritalStatusViewModel GetSelectedItem()
        {
            return bsMaritalStatuses.Current as ListItemMaritalStatusViewModel;
        }

        public MaritalStatusViewModel ShowModifyMaritalStatusForm(ListItemMaritalStatusViewModel itemSelected)
        {
            string msg = string.Format();
        }

        #endregion

        #region Events

        #region Form

        private void frmViewMaritalStatus_Load(object sender, EventArgs e)
        {
            _presenter.SetInitalControlProperties();
            _presenter.LoadMaritalStatuses();
        }

        #endregion

        #region Grid

        #endregion

        #region Buttons

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _presenter.AddNewMaritalStatus();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            _presenter.ModifyMaritalStatus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _presenter.DeleteMaritalStatus();
        }

        #endregion

        #endregion
    }
}
