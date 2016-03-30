using CIS.Presentation.UI.WindowsForms.Administration.Configuration.MaritalStatus;
using CIS.Presentation.UI.WindowsForms.Administration.Configuration.Title;
using System;
using System.Windows.Forms;

namespace CIS.Presentation.UI.WindowsForms
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            try
            {
                frmViewUsers viewUsers = new frmViewUsers();
                viewUsers.MdiParent = this;
                viewUsers.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPatientList_Click(object sender, EventArgs e)
        {
            try
            {
                frmFullPatientList full = new frmFullPatientList();
                full.MdiParent = this;
                full.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmNewPatient newPatientForm = new frmNewPatient();
                newPatientForm.MdiParent = this;
                newPatientForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSearchPatient searchPatientForm = new frmSearchPatient();
                searchPatientForm.MdiParent = this;
                searchPatientForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void newToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                frmNewUser newUserForm = new frmNewUser();
                newUserForm.MdiParent = this;
                newUserForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmNewClinic newClinicForm = new frmNewClinic();
                newClinicForm.MdiParent = this;
                newClinicForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmClinicsList viewClinicianForm = new frmClinicsList();
                viewClinicianForm.MdiParent = this;
                viewClinicianForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAbout aboutForm = new frmAbout();
                aboutForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                frmViewUsers viewUserForm = new frmViewUsers();
                viewUserForm.MdiParent = this;
                viewUserForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void titlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmViewTitles viewTitles = new frmViewTitles();
                viewTitles.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void maritalStatusesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmViewMaritalStatuses viewTitles = new frmViewMaritalStatuses();
                viewTitles.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
