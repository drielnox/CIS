using CIS.Presentation.Logic.Presenter.Administration.Configuration.Title;
using CIS.Presentation.UI.Contracts.Administration.Configuration.Title;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CIS.Presentation.UI.WindowsForms.Administration.Configuration.Titles
{
    public partial class frmViewTitles : Form, IViewTitlesView
    {
        private ViewTitlesPresenter _presenter;

        public frmViewTitles()
        {
            InitializeComponent();

            _presenter = new ViewTitlesPresenter(this);
        }

        #region Events

        #region Form

        private void frmViewTitles_Load(object sender, EventArgs e)
        {
            _presenter.LoadTitles();
        }

        #endregion

        #region Grid

        private void lvTitles_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

        }

        #endregion

        #region Buttons

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #endregion
    }
}
