using CIS.Data.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CIS.Data.DataAccess.Mapping
{
    internal class AppointmentConfiguration : EntityTypeConfiguration<AppointmentTable>
    {
        public AppointmentConfiguration()
        {
            ToTable("appointments");

            HasKey<int>(x => x.Identifier);

            Property<int>(x => x.Identifier)
                .HasColumnName("appointments_id")
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ClinicianId)
                .HasColumnName("clinician_id")
                .IsVariableLength()
                .HasMaxLength(30)
                .IsRequired();
            Property(x => x.ClinicianName)
                .HasColumnName("clinician_name")
                .IsVariableLength()
                .HasMaxLength(45)
                .IsRequired();
            Property<int>(x => x.PatientId)
                .HasColumnName("patient_id")
                .IsRequired();
            Property(x => x.HospitalNumber)
                .HasColumnName("hospital_number")
                .IsVariableLength()
                .HasMaxLength(30)
                .IsOptional();
            Property(x => x.PatientName)
                .HasColumnName("patient_name")
                .IsVariableLength()
                .HasMaxLength(45)
                .IsOptional();
            Property<DateTime>(x => x.DateCreated)
                .HasColumnName("date_of_appointment")
                .IsRequired();
            Property<DateTime>(x => x.TimeCreated)
                .HasColumnName("time_of_appointment")
                .IsRequired();
            Property(x => x.Purpose)
                .HasColumnName("purpose_of_appointment")
                .IsVariableLength()
                .HasMaxLength(100)
                .IsOptional();
            Property(x => x.PatientAttented)
                .HasColumnName("patient_attended")
                .IsVariableLength()
                .HasMaxLength(10)
                .IsOptional();
            Property<DateTime>(x => x.Arrived)
                .HasColumnName("time_arrived")
                .IsOptional();
            Property<DateTime>(x => x.Departed)
                .HasColumnName("time_departed")
                .IsOptional();
            Property(x => x.Result)
                .HasColumnName("appointment_outcome")
                .IsVariableLength()
                .HasMaxLength(300)
                .IsOptional();
            Property<DateTime>(x => x.CreatedAt)
                .HasColumnName("date_created")
                .IsOptional();
            Property<DateTime>(x => x.ModifiedAt)
                .HasColumnName("date_amended")
                .IsOptional();
        }
    }
}
