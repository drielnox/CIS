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
    public partial class frmViewTitles : Form, IViewTitlesView
    {
        private ViewTitlesPresenter _presenter;

        public frmViewTitles()
        {
            InitializeComponent();

            _presenter = new ViewTitlesPresenter(this);
        }

        #region IViewTitlesView

        public void SetInitialGridProperties()
        {
            dgvTitles.AutoGenerateColumns = true;
        }

        public void SetListData(IEnumerable<ListItemTitleViewModel> comboData)
        {
            bsTitles.DataSource = comboData.ToList();
        }

        public TitleViewModel ShowNewTitleForm()
        {
            frmNewTitle frm = new frmNewTitle();
            return frm.ShowDialog(this) == DialogResult.OK
                ? frm.Tag as TitleViewModel
                : null;
        }

        public ListItemTitleViewModel GetSelectedTitle()
        {
            return bsTitles.Current as ListItemTitleViewModel;
        }

        public TitleViewModel ShowModifyTitleForm(ListItemTitleViewModel itemSelected)
        {
            frmModifyTitle frm = new frmModifyTitle(itemSelected);
            return frm.ShowDialog(this) == DialogResult.OK
                ? frm.Tag as TitleViewModel
                : null;
        }

        public bool ShowDeleteTitleDialog(ListItemTitleViewModel itemSelected)
        {
            string msg = string.Format("¿You want really delete the title \"{0}\"?", itemSelected.Description);
            DialogResult result = MessageBox.Show(this, msg, "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            return result == DialogResult.OK;
        }

        #endregion

        #region Events

        #region Form

        private void frmViewTitles_Load(object sender, EventArgs e)
        {
            _presenter.SetInitialControlProperties();
            _presenter.LoadTitles();
        }

        #endregion

        #region Grid

        #endregion

        #region Buttons

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _presenter.AddNewTitle();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            _presenter.ModifyTitle();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _presenter.DeleteTitle();
        }

        #endregion

        #endregion
    }
}
