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
    public partial class frmModifyMaritalStatus : Form, IModifyMaritalStatusView
    {
        private ListItemMaritalStatusViewModel _maritalStatus;

        private ModifyMaritalStatusPresenter _presenter;

        public frmModifyMaritalStatus()
        {
            InitializeComponent();

            _presenter = new ModifyMaritalStatusPresenter(this);
        }

        public frmModifyMaritalStatus(ListItemMaritalStatusViewModel maritalStatus)
            : this()
        {
            _maritalStatus = maritalStatus;
        }

        #region IModifyMaritalStatusView

        public MaritalStatusViewModel GetCurrentMaritalStatus()
        {
            return _maritalStatus;
        }

        public void SetIdentifier(int id)
        {
            txtIdentifier.Text = Convert.ToString(id);
        }

        public void SetAbbreviation(string abbr)
        {
            txtAbbreviation.Text = abbr;
        }

        public void SetDescription(string desc)
        {
            txtDescription.Text = desc;
        }

        public int GetIdentifier()
        {
            string id = txtIdentifier.Text;
            return Convert.ToInt32(id);
        }

        public string GetAbbreviation()
        {
            return txtAbbreviation.Text;
        }

        public string GetDescription()
        {
            return txtDescription.Text;
        }

        public void EnableAcceptButton(bool enable)
        {
            btnAccept.Enabled = enable;
        }

        public void SetTag(MaritalStatusViewModel model)
        {
            Tag = model;
        }

        #endregion

        #region Events

        #region Form

        private void frmModifyMaritalStatus_Load(object sender, EventArgs e)
        {
            _presenter.LoadTitle();
        }

        #endregion

        #region Control

        private void txtAbbreviation_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtAbbreviation_Validated(object sender, EventArgs e)
        {
            _presenter.EnableAccept();
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtDescription_Validated(object sender, EventArgs e)
        {
            _presenter.EnableAccept();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            _presenter.Accept();
        }

        #endregion

        #endregion
    }
}
