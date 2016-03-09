using CIS.Data.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CIS.Data.DataAccess.Mapping
{
    internal class PatientConfiguration : EntityTypeConfiguration<PatientTable>
    {
        public PatientConfiguration()
        {
            ToTable("patients");

            HasKey<int>(x => x.Identifier);

            Property<int>(x => x.Identifier)
                .HasColumnName("Patient_ID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.HospitalNumber)
                .HasColumnName("HospitalNumber")
                .IsVariableLength()
                .HasMaxLength(45)
                .IsOptional();
            Property(x => x.Title)
                .HasColumnName("Title")
                .IsVariableLength()
                .HasMaxLength(10)
                .IsOptional();
            Property(x => x.LastName)
                .HasColumnName("lName")
                .IsVariableLength()
                .HasMaxLength(45)
                .IsRequired();
            Property(x => x.FirstName)
                .HasColumnName("fName")
                .IsVariableLength()
                .HasMaxLength(45)
                .IsRequired();
            Property(x => x.MiddleName)
                .HasColumnName("mName")
                .IsVariableLength()
                .HasMaxLength(45)
                .IsOptional();
            Property(x => x.Gender)
                .HasColumnName("Gender")
                .IsVariableLength()
                .HasMaxLength(10)
                .IsRequired();
            Property<DateTime>(x => x.BirthDate)
                .HasColumnName("DateOfBirth")
                .HasColumnType("date")
                .IsOptional();
            Property<int>(x => x.Phone)
                .HasColumnName("Phone")
                .IsOptional();
            Property<int>(x => x.MobilePhone)
                .HasColumnName("Mobile_Phone")
                .IsOptional();
            Property(x => x.Email)
                .HasColumnName("Email")
                .IsVariableLength()
                .HasMaxLength(45)
                .IsOptional();
            Property(x => x.HomeAddress)
                .HasColumnName("HomeAddress")
                .IsVariableLength()
                .HasMaxLength(150)
                .IsOptional();
            Property(x => x.City)
                .HasColumnName("City")
                .IsVariableLength()
                .HasMaxLength(45)
                .IsOptional();
            Property(x => x.State)
                .HasColumnName("State")
                .IsVariableLength()
                .HasMaxLength(45)
                .IsOptional();
            Property(x => x.MaritalStatus)
                .HasColumnName("MaritalStatus")
                .IsVariableLength()
                .HasMaxLength(45)
                .IsOptional();
            Property(x => x.PatientConsultant)
                .HasColumnName("Patient_Consultant")
                .IsVariableLength()
                .HasMaxLength(45)
                .IsOptional();
            Property(x => x.Nationality)
                .HasColumnName("Nationality")
                .IsVariableLength()
                .HasMaxLength(45)
                .IsOptional();
            Property(x => x.StateOfOrigin)
                .HasColumnName("State_of_Origin")
                .IsVariableLength()
                .HasMaxLength(45)
                .IsOptional();
            Property(x => x.Hometown)
                .HasColumnName("HomeTown")
                .IsVariableLength()
                .HasMaxLength(45)
                .IsOptional();
            Property(x => x.PlaceOfBirth)
                .HasColumnName("Place_of_Birth")
                .IsVariableLength()
                .HasMaxLength(45)
                .IsOptional();
            Property(x => x.Religion)
                .HasColumnName("Religion")
                .IsVariableLength()
                .HasMaxLength(30)
                .IsOptional();
            Property(x => x.PlaceOfBirth)
                .HasColumnName("Place_of_Birth")
                .IsVariableLength()
                .HasMaxLength(45)
                .IsOptional();
            Property(x => x.Occupation)
                .HasColumnName("Occupation")
                .IsVariableLength()
                .HasMaxLength(45)
                .IsOptional();
            Property(x => x.OfficeAddress)
                .HasColumnName("OfficeAddress")
                .IsVariableLength()
                .HasMaxLength(150)
                .IsOptional();
            Property(x => x.Photo)
                .HasColumnName("PatientImage")
                .IsVariableLength()
                .HasMaxLength(1000) // TODO: see if this is correct.
                .IsOptional();
            Property(x => x.NationalIdType)
                .HasColumnName("National_ID_Type")
                .HasMaxLength(45)
                .IsOptional();
            Property(x => x.NationalIdNumber)
                .HasColumnName("National_ID_Number")
                .HasMaxLength(45)
                .IsOptional();
            Property(x => x.NextOfKin)
                .HasColumnName("Next_of_Kin")
                .HasMaxLength(45)
                .IsOptional();
            Property(x => x.AddressNextOfKin)
                .HasColumnName("Address_NOK")
                .HasMaxLength(45)
                .IsOptional();
            Property(x => x.PhoneNextOfKin)
                .HasColumnName("Phone_NOK")
                .IsOptional();
            Property(x => x.EmailNextOfKin)
                .HasColumnName("Email_NOK")
                .HasMaxLength(45)
                .IsOptional();
            Property(x => x.NextOfKinRelationship)
                .HasColumnName("NOK_Relationship")
                .HasMaxLength(45)
                .IsOptional();
            Property(x => x.NameOfFather)
                .HasColumnName("Name_of_Father")
                .HasMaxLength(45)
                .IsOptional();
            Property(x => x.NameOfMother)
                .HasColumnName("Name_of_Mother")
                .HasMaxLength(45)
                .IsOptional();
            Property(x => x.HealthInsuranceProvider)
                .HasColumnName("Health_Insurance_Prov")
                .HasMaxLength(45)
                .IsOptional();
            Property(x => x.AddressHealthInsuranceProvider)
                .HasColumnName("Address_HIP")
                .HasMaxLength(45)
                .IsOptional();
            Property(x => x.PhoneHealthInsuranceProvider)
                .HasColumnName("Phone_HIP")
                .IsOptional();
            Property(x => x.EmailHealthInsuranceProvider)
                .HasColumnName("Email_HIP")
                .HasMaxLength(45)
                .IsOptional();
            Property<DateTime>(x => x.DateRegistred)
                .HasColumnName("Date_Registered")
                .IsOptional();
            Property(x => x.UserCreated)
                .HasColumnName("User_Created")
                .HasMaxLength(45)
                .IsOptional();
            Property<DateTime>(x => x.DateAmended)
                .HasColumnName("Date_Amended")
                .IsOptional();
            Property(x => x.UserAmended)
                .HasColumnName("User_Amended")
                .HasMaxLength(42)
                .IsOptional();
        }
    }
}
