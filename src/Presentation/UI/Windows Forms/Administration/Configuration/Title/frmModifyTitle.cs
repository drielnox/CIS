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
    }
}
