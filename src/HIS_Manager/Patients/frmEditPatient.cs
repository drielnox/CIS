using CIS.Presentation.Logic.Presenter.Patients;
using CIS.Presentation.Model.Common;
using CIS.Presentation.Model.Patients;
using CIS.Presentation.UI.Contracts.Patients;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

            _presenter.LoadTitles();
            _presenter.LoadGenders();
            _presenter.LoadMaritalStatus();
            _presenter.LoadNationalIdentificationTypes();
            _presenter.LoadKinRelationships();
            _presenter.LoadClinics();

            _presenter.LoadPatient(_patientSelected);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _presenter.Save();

            MessageBox.Show("Patient Record Updated");
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

        private void button2_Click(object sender, EventArgs e)
        {
            //close this module
            this.Close();

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

        #endregion

        public void LoadPatient(EditPatientViewModel patient)
        {
            txtPatientId.Text = patient.Identifier.ToString();
            txtHospitalNumber.Text = patient.HospitalNumber;
            cboTitle.SelectedValue = patient.Title;
            txtLastName.Text = patient.LastName;
            txtFirstName.Text = patient.FirstName;
            txtMiddleName.Text = patient.MiddleName;
            cboGender.SelectedValue = patient.Genre;
            dtpBirthdate.Value = patient.Birthdate;
            cboMaritalStatus.SelectedValue = patient.MaritalStatus;
            txtConsultant.Text = patient.Consultant;
            txtMobilePhone.Text = patient.MobilePhone;
            txtPhone.Text = patient.Phone;
            txtEmail.Text = patient.Email;
            txtHomeAddress.Text = patient.HomeAddress;
            txtCity.Text = patient.City;
            txtState.Text = patient.State;
            txtOfficeAddress.Text = patient.WorkAddress;
            txtNationality.Text = patient.Nationality;
            txtStateOfOrigin.Text = patient.StateOfOrigin;
            txtTownOfOrigin.Text = patient.TownOfOrigin;
            txtPlaceOfBirth.Text = patient.PlaceOfBirth;
            txtReligion.Text = patient.Religion;
            txtOccupation.Text = patient.Occupation;
            cboNationalIdType.SelectedValue = patient.NationalIdType;
            txtNationalIdNumber.Text = patient.NationalIdNumber;
            txtNameOfKin.Text = patient.NextOfKin;
            txtNameOfKinAddress.Text = patient.NextOfKinAddress;
            txtNameOfKinPhone.Text = patient.NextOfKinPhone;
            txtNameOfKinEmail.Text = patient.NextOfKinEmail;
            cboNameOfKinRelationship.SelectedValue = patient.NextOfKinRelationship;
            txtFatherName.Text = patient.FatherName;
            txtMotherName.Text = patient.MotherName;
            txtHealthInsurance.Text = patient.HealthInsuranceProvider;
            txtHealthInsuranceAddress.Text = patient.HealthInsuranceProviderAddress;
            txtHealthInsurancePhone.Text = patient.HealthInsuranceProviderPhone;
            txtHealthInsuranceEmail.Text = patient.HealthInsuranceProviderEmail;
            pbPatientImage.Image = LoadImage(Encoding.Default.GetBytes(patient.Photo));
        }

        private void record_delete()
        {
            _presenter.DeletePatient();

            MessageBox.Show("Patient Record Deleted");
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

        private void LoadReport()
        {
            _presenter.LoadReport();
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
        
        public void LoadTitles(IEnumerable<ComboTitleViewModel> titles)
        {
            cboTitle.DataSource = titles.ToList();
            cboTitle.DisplayMember = "Description";
            cboTitle.ValueMember = "Identifier";
        }

        public void LoadGenres(IEnumerable<ComboGenreViewModel> genrers)
        {
            cboGender.DataSource = genrers.ToList();
            cboGender.DisplayMember = "Description";
            cboGender.ValueMember = "Identifier";
        }

        public void LoadMaritalStatuses(IEnumerable<ComboMaritalStatusViewModel> maritalStatuses)
        {
            cboMaritalStatus.DataSource = maritalStatuses.ToList();
            cboMaritalStatus.DisplayMember = "Description";
            cboMaritalStatus.ValueMember = "Identifier";
        }

        public void LoadNationalIdTypes(IEnumerable<ComboNationalIdTypesViewModel> nationalIdTypes)
        {
            cboNationalIdType.DataSource = nationalIdTypes.ToList();
            cboNationalIdType.DisplayMember = "Description";
            cboNationalIdType.ValueMember = "Identifier";
        }

        public void LoadKinRelationships(IEnumerable<ComboKinRelationshipViewModel> relatioships)
        {
            cboNameOfKinRelationship.DataSource = relatioships.ToList();
            cboNameOfKinRelationship.DisplayMember = "Description";
            cboNameOfKinRelationship.ValueMember = "Identifier";
        }

        public void LoadClinics(IEnumerable<ClinicListViewModel> clinics)
        {
            dgvClinics.DataSource = clinics;
        }

        public EditPatientViewModel GetPatient()
        {
            return new EditPatientViewModel()
            {
                Identifier = Convert.ToInt32(txtPatientId.Text),
                HospitalNumber = txtHospitalNumber.Text,
                Title = Convert.ToInt32(cboTitle.SelectedValue),
                LastName = txtLastName.Text,
                FirstName = txtFirstName.Text,
                MiddleName = txtMiddleName.Text,
                Genre = Convert.ToInt32(cboGender.SelectedValue),
                Birthdate = dtpBirthdate.Value,
                Phone = txtPhone.Text,
                MobilePhone = txtMobilePhone.Text,
                Email = txtEmail.Text,
                HomeAddress = txtHomeAddress.Text,
                City = txtCity.Text,
                State = txtState.Text,
                MaritalStatus = Convert.ToInt32(cboMaritalStatus.SelectedValue),
                Consultant = txtConsultant.Text,
                Nationality = txtNationality.Text,
                StateOfOrigin = txtStateOfOrigin.Text,
                TownOfOrigin = txtTownOfOrigin.Text,
                PlaceOfBirth = txtPlaceOfBirth.Text,
                Religion = txtReligion.Text,
                Occupation = txtOccupation.Text,
                WorkAddress = txtOfficeAddress.Text,
                NationalIdType = Convert.ToInt32(cboNationalIdType.SelectedValue),
                NationalIdNumber = txtNationalIdNumber.Text,
                NextOfKin = txtNameOfKin.Text,
                NextOfKinAddress = txtNameOfKinAddress.Text,
                NextOfKinPhone = txtNameOfKinPhone.Text,
                NextOfKinEmail = txtNameOfKinEmail.Text,
                NextOfKinRelationship = Convert.ToInt32(cboNameOfKinRelationship.SelectedValue),
                FatherName = txtFatherName.Text,
                MotherName = txtMotherName.Text,
                HealthInsuranceProvider = txtHealthInsurance.Text,
                HealthInsuranceProviderAddress = txtHealthInsuranceAddress.Text,
                HealthInsuranceProviderPhone = txtHealthInsurancePhone.Text,
                HealthInsuranceProviderEmail = txtHealthInsuranceEmail.Text,
                DateAmended = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),
                Photo = GetBytesFromImage().ToString()
            };
        }

        public int GetCurrentPatientId()
        {
            return _patientSelected.Identifier;
        }

        public void SetReport(string report)
        {
            richTextBox1.Text = "Patient Record: " + Environment.NewLine + report;
        }
    }
}