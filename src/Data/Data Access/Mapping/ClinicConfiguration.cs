using CIS.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace CIS.Data.DataAccess.Mapping
{
    class ClinicConfiguration : EntityTypeConfiguration<ClinicTable>
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
            Property(x => x.Title.Identifier)
                .HasColumnName("title")
                .IsOptional();
        }
    }
}
