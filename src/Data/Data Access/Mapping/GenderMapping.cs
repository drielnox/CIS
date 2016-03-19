using CIS.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace CIS.Data.DataAccess.Mapping
{
    internal class GenderMapping : EntityTypeConfiguration<GenderTable>
    {
        public GenderMapping()
        {
            ToTable("Gender");

            HasKey<int>(x => x.Identifier);

            Property<int>(x => x.Identifier)
                .HasColumnName("GenderId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Abbreviation)
                .HasColumnName("Abbreviation")
                .IsFixedLength()
                .HasMaxLength(3)
                .IsOptional();
            Property(x => x.Description)
                .HasColumnName("Description")
                .IsVariableLength()
                .HasMaxLength(30)
                .IsRequired();
        }
    }
}
