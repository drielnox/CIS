using CIS.Presentation.Logic.Presenter.Administration.Configuration.Title;
using CIS.Presentation.Model.Administration.Title;
using CIS.Presentation.UI.Contracts.Administration.Configuration.Title;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CIS.Presentation.UI.WindowsForms.Administration.Configuration.Title
{
    public partial class frmModifyTitle : Form, IModifyTitleView
    {
        private ModifyTitlePresenter _presenter;

        private ListItemTitleViewModel _itemSelected;

        public frmModifyTitle()
        {
            InitializeComponent();

            _presenter = new ModifyTitlePresenter(this);
        }

        public frmModifyTitle(ListItemTitleViewModel itemSelected)
            : this()
        {
            _itemSelected = itemSelected;
        }

        #region IModifyTitleView

        public TitleViewModel GetCurrentTitle()
        {
            TitleViewModel model = new TitleViewModel
            {
                Identifier = _itemSelected.Identifier,
                Abbreviation = _itemSelected.Abbreviation,
                Description = _itemSelected.Description
            };
            return model;
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

        public void EnableAcceptButton(bool enable)
        {
            btnAccept.Enabled = enable;
        }

        public int GetIdentifier()
        {
            string id = txtDescription.Text;
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

        public void SetTag(TitleViewModel model)
        {
            Tag = model;
        }

        #endregion

        #region Events

        private void frmModifyTitle_Load(object sender, EventArgs e)
        {
            _presenter.LoadTitle();
        }

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
    }
}
