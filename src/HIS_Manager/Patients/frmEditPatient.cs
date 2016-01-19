using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using CIS.Data.DataAccess;
using CIS.Presentation.UI.Contracts.Patients;
using CIS.Presentation.Logic.Presenter.Patients;
using CIS.Presentation.Model.Patients;

namespace CIS.Presentation.UI.WindowsForms
{
    public partial class frmEditPatient : Form, IEditPatientView
    {
        private EditPatientViewModel _patientSelected;
        private EditPatientPresenter _presenter;

        public frmEditPatient()
        {
            InitializeComponent();
            _presenter = new EditPatientPresenter(this);
        }

        public frmEditPatient(EditPatientViewModel patient)
            : this()
        {
            _patientSelected = patient;
        }

        #region Form Events

        private void frmPatientRecord_Load(object sender, EventArgs e)
        {
            txtPatImage.Visible = false;

            _presenter.LoadPatient(_patientSelected);

            LoadClinics();
        }

        #endregion

        public void LoadPatient(EditPatientViewModel patient)
        {
            txtPatientId.Text = Convert.ToString(_patientSelected.Cells[0]);
            txtHospitalNumber.Text = Convert.ToString(_patientSelected.Cells[1]);
            cboTitle.Text = Convert.ToString(_patientSelected.Cells[2]);
            txtLastName.Text = Convert.ToString(_patientSelected.Cells[3]);
            txtFirstName.Text = Convert.ToString(_patientSelected.Cells[4]);
            txtMiddleName.Text = Convert.ToString(_patientSelected.Cells[5]);
            cboGender.Text = Convert.ToString(_patientSelected.Cells[6]);
            txtBirthdate.Text = Convert.ToString(_patientSelected.Cells[7]);
            cboMaritalStatus.Text = Convert.ToString(_patientSelected.Cells[14]);
            txtConsultant.Text = Convert.ToString(_patientSelected.Cells[15]);
            txtMobilePhone.Text = Convert.ToString(_patientSelected.Cells[9]);
            txtPhone.Text = Convert.ToString(_patientSelected.Cells[8]);
            txtEmail.Text = Convert.ToString(_patientSelected.Cells[10]);
            txtHomeAddress.Text = Convert.ToString(_patientSelected.Cells[11]);
            txtCity.Text = Convert.ToString(_patientSelected.Cells[12]);
            txtState.Text = Convert.ToString(_patientSelected.Cells[13]);
            txtOfficeAddress.Text = Convert.ToString(_patientSelected.Cells[22]);
            txtNat.Text = Convert.ToString(_patientSelected.Cells[16]);
            txtSOrigin.Text = Convert.ToString(_patientSelected.Cells[17]);
            txtTOrigin.Text = Convert.ToString(_patientSelected.Cells[18]);
            txtPoB.Text = Convert.ToString(_patientSelected.Cells[19]);
            txtReligion.Text = Convert.ToString(_patientSelected.Cells[20]);
            txtOccupation.Text = Convert.ToString(_patientSelected.Cells[21]);
            cmbNIDType.Text = Convert.ToString(_patientSelected.Cells[24]);
            txtNidNumber.Text = Convert.ToString(_patientSelected.Cells[25]);
            txtNok.Text = Convert.ToString(_patientSelected.Cells[26]);
            txtNoKAddress.Text = Convert.ToString(_patientSelected.Cells[27]);
            txtNoKPhone.Text = Convert.ToString(_patientSelected.Cells[28]);
            txtNoKEmail.Text = Convert.ToString(_patientSelected.Cells[29]);
            cmbNokRelationship.Text = Convert.ToString(_patientSelected.Cells[30]);
            txtFather.Text = Convert.ToString(_patientSelected.Cells[31]);
            txtMother.Text = Convert.ToString(_patientSelected.Cells[32]);
            txtHealthIns.Text = Convert.ToString(_patientSelected.Cells[33]);
            txtHealthAddr.Text = Convert.ToString(_patientSelected.Cells[34]);
            txtHealthPhone.Text = Convert.ToString(_patientSelected.Cells[35]);
            txtHealthEmail.Text = Convert.ToString(_patientSelected.Cells[36]);
            pbPatientImage.Image = LoadImage(Encoding.Default.GetBytes(_patientSelected.Cells[37].ToString()));
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtDateAmend.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            var patient = new Patient()
            {
                Identifier = int.Parse(txtPatientId.Text),
                HospitalNumber = int.Parse(txtHospitalNumber.Text),
                Title = (Title)Enum.Parse(typeof(Title), cboTitle.Text),
                LastName = txtLastName.Text,
                FirstName = txtFirstName.Text,
                MiddleName = txtMiddleName.Text,
                Gender = (Gender)Enum.Parse(typeof(Gender), cboGender.Text),
                BirthDate = DateTime.Parse(txtBirthdate.Text),
                Phone = int.Parse(txtPhone.Text),
                MobilePhone = int.Parse(txtMobilePhone.Text),
                Email = txtEmail.Text,
                HomeAddress = txtHomeAddress.Text,
                City = txtCity.Text,
                State = txtState.Text,
                MaritalStatus = (MaritalStatus)Enum.Parse(typeof(MaritalStatus), cboMaritalStatus.Text),
                PatientConsultant = txtConsultant.Text,
                Nationality = txtNat.Text,
                StateOfOrigin = txtSOrigin.Text,
                Hometown = txtTOrigin.Text,
                PlaceOfBirth = txtPoB.Text,
                Religion = txtReligion.Text,
                Occupation = txtOccupation.Text,
                OfficeAddress = txtOfficeAddress.Text,
                NationalIdType = cmbNIDType.Text,
                NationalIdNumber = txtNidNumber.Text,
                NextOfKin = txtNok.Text,
                AddressNextOfKin = txtNoKAddress.Text,
                PhoneNextOfKin = int.Parse(txtNoKPhone.Text),
                EmailNextOfKin = txtNoKEmail.Text,
                NextOfKinRelationship = cmbNokRelationship.Text,
                NameOfFather = txtFather.Text,
                NameOfMother = txtMother.Text,
                HealthInsuranceProvider = txtHealthIns.Text,
                AddressHealthInsuranceProvider = txtHealthAddr.Text,
                PhoneHealthInsuranceProvider = int.Parse(txtHealthPhone.Text),
                EmailHealthInsuranceProvider = txtHealthEmail.Text,
                DateAmended = txtDateAmend.Text,
                Photo = GetBytesFromImage()
            };

            using (ClinicModel context = new ClinicModel())
            {
                context.Patients.Add(patient);

                context.SaveChanges();
            }

            GetBytesFromImage();

            MessageBox.Show("Patient Record Updated");
        }

        private void record_delete()
        {
            using (ClinicModel context = new ClinicModel())
            {
                context.Patients.Remove(new Patient() { Identifier = int.Parse(txtPatientId.Text) });
            }

            MessageBox.Show("Patient Record Deleted");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //load patient's picture from the system
            string picFile = "";
            OpenFD.InitialDirectory = "C:";
            OpenFD.Title = "Load Patient Picture";
            OpenFD.Filter = "Jpeg Files|*.jpg|GIF Images|*.gif";
            OpenFD.FileName = "";

            if (OpenFD.ShowDialog() == DialogResult.OK)
            {
                picFile = OpenFD.FileName;
                txtPatImage.Text = picFile;
                pbPatientImage.Image = Image.FromFile(picFile);
            }

        }

        private byte[] GetBytesFromImage()
        {
            byte[] imageData;

            using (var file = new FileStream(txtPatImage.Text, FileMode.Open, FileAccess.Read))
            {
                using (var bin = new BinaryReader(file))
                {
                    imageData = bin.ReadBytes((int)file.Length);
                }
            }

            return imageData;
        }

        private Image LoadImage(byte[] photo)
        {
            MemoryStream stm = new MemoryStream(photo);
            return Image.FromStream(stm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //close this module
            this.Close();

        }

        private void LoadReport()
        {
            //load patient's demographics on a textbox control for hardcopy printing
            richTextBox1.Text = "Patient Record: " + Environment.NewLine + Environment.NewLine + lblPatientId.Text + ": " + txtPatientId.Text + Environment.NewLine + lblHospitalNumber.Text + ": " + txtHospitalNumber.Text + Environment.NewLine + lblTitle.Text + ": " + cboTitle.Text + Environment.NewLine + lblFamilyName.Text + ": " + txtLastName.Text + Environment.NewLine + lblFirstName.Text + ": " + txtFirstName.Text + Environment.NewLine + "Middle Name" + ": " + txtMiddleName.Text + Environment.NewLine + "Gender" + ": " + cboGender.Text + Environment.NewLine + "Date of Birth" + ": " + txtBirthdate.Text + Environment.NewLine + "Phone" + ": " + txtPhone.Text + Environment.NewLine + "Mobile Phone" + ": " + txtMobilePhone.Text + Environment.NewLine + "Email" + ": " + txtEmail.Text + Environment.NewLine + "Home Address" + ": " + txtHomeAddress.Text + Environment.NewLine + "City" + ": " + txtCity.Text + Environment.NewLine + "State" + ": " + txtState.Text + Environment.NewLine + "Marital Status" + ": " + cboMaritalStatus.Text + Environment.NewLine + "Nationality" + ": " + txtNat.Text + Environment.NewLine + "State of Origin" + ": " + txtSOrigin.Text + Environment.NewLine + "Town of Origin" + ": " + txtTOrigin.Text + Environment.NewLine + "Place of Birth" + ": " + txtPoB.Text + Environment.NewLine + "Religion" + ": " + txtReligion.Text + Environment.NewLine + "Occupation" + ": " + txtOccupation.Text + Environment.NewLine + "Office Address" + ": " + txtOfficeAddress.Text + Environment.NewLine + "National ID Type" + ": " + cmbNIDType.Text + Environment.NewLine + "National ID Number" + ": " + txtNidNumber.Text + Environment.NewLine + "Next of Kin" + ": " + txtNok.Text + Environment.NewLine + "Address" + ": " + txtNoKAddress.Text + Environment.NewLine + "Phone" + ": " + txtNoKPhone.Text + Environment.NewLine + "Email" + ": " + txtNoKEmail.Text + Environment.NewLine + "Relationship" + ": " + cmbNokRelationship.Text;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // calling the lodReport code block before printing on hardcopy
            LoadReport();

            // print patient's demographic on hardcopy 
            PrintDialog print = new PrintDialog();

            System.Drawing.Printing.PrintDocument printDoc = new System.Drawing.Printing.PrintDocument();

            print.AllowSomePages = true;

            print.ShowHelp = true;

            printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDoc_PrintPage);

            print.Document = printDoc;

            if (print.ShowDialog(this) == DialogResult.OK)
            {
                printDoc.Print();
            }
        }

        private void printDoc_PrintPage(Object Sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //set printing section properties
            string strPrint = richTextBox1.Text;
            int charCount = 0;
            int lineCount = 0;

            e.Graphics.MeasureString(strPrint, this.Font, e.MarginBounds.Size, StringFormat.GenericTypographic, out charCount, out lineCount);
            e.Graphics.DrawString(strPrint, this.Font, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic);
            strPrint = strPrint.Substring(charCount);
            if (strPrint.Length > 0)
            {
                //e.HasMorePages = true;
                e.Graphics.DrawString(strPrint, this.Font, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic);

            }
            else
            {
                e.HasMorePages = false;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtBirthdate.Text = Convert.ToString(dtpBirthdate.Value.AddDays(0).ToString("yyyy/MM/dd"));
        }

        private void LoadClinics()
        {
            List<Clinic> clinics = new List<Clinic>();

            using (ClinicModel context = new ClinicModel())
            {
                clinics = context.Clinicians.ToList();
            }

            dgvClinics.DataSource = clinics;
        }

        private void btnLoadClinic_Click(object sender, EventArgs e)
        {
            //load preferred clinician into patient's demographics
            try
            {
                DataGridViewRow dr = dgvClinics.SelectedRows[0];
                txtConsultant.Text = dr.Cells[1].Value.ToString() + " " + dr.Cells[0].Value.ToString();
                grpClinics.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search Clinics");
            }

        }

        private void btnSearchClinic_Click(object sender, EventArgs e)
        {
            // display list of clinicians to select from
            grpClinics.Visible = true;
            grpClinics.Left = 420; ;
            grpClinics.Top = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grpClinics.Visible = false;

        }

        private void dgridClinics_DoubleClick(object sender, EventArgs e)
        {
            //displayed list of clinicians to select as the patient's preffered 
            try
            {
                DataGridViewRow dr = dgvClinics.SelectedRows[0];
                txtConsultant.Text = dr.Cells[1].Value.ToString() + " " + dr.Cells[0].Value.ToString();
                grpClinics.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search Clinics");
            }
        }
    }
}