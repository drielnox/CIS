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
    public partial class frmNewTitle : Form, INewTitleView
    {
        private NewTitlePresenter _presenter;

        public frmNewTitle()
        {
            InitializeComponent();

            _presenter = new NewTitlePresenter(this);
        }

        #region INewTitleView

        public string GetAbbreviation()
        {
            return txtAbbreviation.Text;
        }

        public string GetDescription()
        {
            return txtDescription.Text;
        }

        public void SetFormTag(TitleViewModel model)
        {
            Tag = model;
        }

        #endregion

        #region Events

        private void btnAccept_Click(object sender, EventArgs e)
        {
            _presenter.Accept();
        }

        #endregion
    }
}
