using CIS.Presentation.Logic.Presenter.Clinicians;
using CIS.Presentation.Model;
using CIS.Presentation.Model.Clinicians;
using CIS.Presentation.UI.Contracts.Clinicians;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CIS.Presentation.UI.WindowsForms
{
    public partial class frmEditClinic : Form, IEditClinicView
    {
        private EditClinicViewModel _viewModel;
        private EditClinicPresenter _presenter;

        public frmEditClinic()
        {
            InitializeComponent();
            _presenter = new EditClinicPresenter(this);
        }

        public frmEditClinic(EditClinicViewModel clinic)
            : this()
        {
            _viewModel = clinic;
        }

        private void frmClinicianRecord_Load(object sender, EventArgs e)
        {
            _presenter.LoadTitles();
            _presenter.SetFormData(_viewModel);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _presenter.Save();
                MessageBox.Show("Patient Record Updated");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Patient Record");
            }
        }

        public void LoadTitles(IEnumerable<ComboTitleViewModel> titles)
        {
            cboTitle.DataSource = titles.ToList();
            cboTitle.DisplayMember = "Description";
            cboTitle.ValueMember = "Identifier";
        }

        public void LoadFormData(EditClinicViewModel viewModel)
        {
            txtClinicianNumber.Text = viewModel.InternalCode;
            cboTitle.SelectedValue = viewModel.Title;
            txtLastName.Text = viewModel.LastName;
            txtFirstName.Text = viewModel.FirstName;
            txtSpecialty.Text = viewModel.Specialty;
            txtDepartment.Text = viewModel.Department;
            txtAddress.Text = viewModel.Address;
            txtPhone.Text = viewModel.Telephone;
            txtEmail.Text = viewModel.Email;
        }

        public EditClinicViewModel GetFormData()
        {
            return new EditClinicViewModel
            {
                Identifier = _viewModel.Identifier,
                InternalCode = txtClinicianNumber.Text,
                Title = cboTitle.SelectedValue,
                LastName = txtLastName.Text,
                FirstName = txtFirstName.Text,
                Specialty = txtSpecialty.Text,
                Department = txtDepartment.Text,
                Address = txtAddress.Text,
                Telephone = txtPhone.Text,
                Email = txtEmail.Text,
            };
        }
    }
}
