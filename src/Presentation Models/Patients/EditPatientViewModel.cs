
using System;
using System.Text;

namespace CIS.Presentation.Model.Patients
{
    public class EditPatientViewModel
    {
        public int Identifier { get; set; }

        public string HospitalNumber { get; set; }

        public int Title { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public int Genre { get; set; }

        public DateTime Birthdate { get; set; }

        public int MaritalStatus { get; set; }

        public string Consultant { get; set; }

        public string MobilePhone { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string HomeAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string WorkAddress { get; set; }

        public string Nationality { get; set; }

        public string StateOfOrigin { get; set; }

        public string TownOfOrigin { get; set; }

        public string PlaceOfBirth { get; set; }

        public string Religion { get; set; }

        public string Occupation { get; set; }

        public int NationalIdType { get; set; }

        public string NationalIdNumber { get; set; }

        public string NextOfKin { get; set; }

        public string NextOfKinAddress { get; set; }

        public string NextOfKinPhone { get; set; }

        public string NextOfKinEmail { get; set; }

        public int NextOfKinRelationship { get; set; }

        public string FatherName { get; set; }

        public string MotherName { get; set; }

        public string HealthInsuranceProvider { get; set; }

        public string HealthInsuranceProviderAddress { get; set; }

        public string HealthInsuranceProviderPhone { get; set; }

        public string HealthInsuranceProviderEmail { get; set; }

        public string Photo { get; set; }

        public string DateAmended { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine("Patient Record:");
            sb.AppendLine(string.Empty);
            sb.AppendLine(string.Empty);
            sb.AppendFormat("Identifier: {0}", Identifier);
            sb.AppendFormat("Hospital Number: {0}", HospitalNumber);
            sb.AppendFormat("Title: {0}", Title);
            sb.AppendFormat("Last Name: {0}", LastName);
            sb.AppendFormat("First Name: {0}", FirstName);
            sb.AppendFormat("Middle Name: {0}", MiddleName);
            sb.AppendFormat("Gender: {0}", Genre);
            sb.AppendFormat("Birthdate: {0}", Birthdate);
            sb.AppendFormat("Phone: {0}", Phone);
            sb.AppendFormat("Mobile phone: {0}", MobilePhone);
            sb.AppendFormat("Email: {0}", Email);
            sb.AppendFormat("Home Address: {0}", HomeAddress);
            sb.AppendFormat("City: {0}", City);
            sb.AppendFormat("State: {0}", State);
            sb.AppendFormat("Marital Status: {0}", MaritalStatus);
            // "Nationality" + ": " + txtNationality.Text + Environment.NewLine + "State of Origin" + ": " + txtStateOfOrigin.Text + Environment.NewLine + "Town of Origin" + ": " + txtTownOfOrigin.Text + Environment.NewLine + "Place of Birth" + ": " + txtPlaceOfBirth.Text + Environment.NewLine + "Religion" + ": " + txtReligion.Text + Environment.NewLine + "Occupation" + ": " + txtOccupation.Text + Environment.NewLine + "Office Address" + ": " + txtOfficeAddress.Text + Environment.NewLine + "National ID Type" + ": " + cboNationalIdType.Text + Environment.NewLine + "National ID Number" + ": " + txtNationalIdNumber.Text + Environment.NewLine + "Next of Kin" + ": " + txtNameOfKin.Text + Environment.NewLine + "Address" + ": " + txtNameOfKinAddress.Text + Environment.NewLine + "Phone" + ": " + txtNameOfKinPhone.Text + Environment.NewLine + "Email" + ": " + txtNameOfKinEmail.Text + Environment.NewLine + "Relationship" + ": " + cboNameOfKinRelationship.Text;

            return sb.ToString();
        }
    }
}