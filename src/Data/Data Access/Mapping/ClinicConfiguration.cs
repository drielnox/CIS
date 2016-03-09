using CIS.Data.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CIS.Data.DataAccess.Mapping
{
    internal class ClinicConfiguration : EntityTypeConfiguration<ClinicTable>
    {
        public ClinicConfiguration()
        {
            ToTable("clinicians");

            HasKey<int>(x => x.Identifier);

            Property<int>(x => x.Identifier)
                .HasColumnName("clnc_sys_id")
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.InternalCode)
                .HasColumnName("clnc_id")
                .IsVariableLength()
                .HasMaxLength(45)
                .IsRequired();
            Property(x => x.Title)
                .HasColumnName("title")
                .IsVariableLength()
                .HasMaxLength(30)
                .IsOptional();
            Property(x => x.LastName)
                .HasColumnName("lastName")
                .IsVariableLength()
                .HasMaxLength(45)
                .IsRequired();
            Property(x => x.FirstName)
                .HasColumnName("firstName")
                .IsVariableLength()
                .HasMaxLength(45)
                .IsOptional();
            Property(x => x.Specialty)
                .HasColumnName("specialty")
                .IsVariableLength()
                .HasMaxLength(45)
                .IsOptional();
            Property(x => x.Department)
                .HasColumnName("department")
                .IsVariableLength()
                .HasMaxLength(45)
                .IsOptional();
            Property(x => x.Address)
                .HasColumnName("address")
                .IsVariableLength()
                .HasMaxLength(45)
                .IsOptional();
            Property(x => x.Telephone)
                .HasColumnName("phone")
                .IsVariableLength()
                .HasMaxLength(35)
                .IsOptional();
            Property(x => x.Email)
                .HasColumnName("email")
                .IsVariableLength()
                .HasMaxLength(45)
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
