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
                viewUsers.ShowDialog();
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
                full.ShowDialog();
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
                frmNewPatient register = new frmNewPatient();
                register.ShowDialog();
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
                frmSearchPatient search = new frmSearchPatient();
                search.ShowDialog();
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
                frmNewUser new_user = new frmNewUser();
                new_user.ShowDialog();
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
                frmNewClinic clinic1 = new frmNewClinic();
                clinic1.ShowDialog();
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
                frmClinicsList clinic2 = new frmClinicsList();
                clinic2.ShowDialog();
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
                frmAbout About = new frmAbout();
                About.ShowDialog();
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
                frmViewUsers frm = new frmViewUsers();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
