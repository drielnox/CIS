using CIS.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CIS.Data.DataAccess.Mapping
{
    internal class UserConfiguration : EntityTypeConfiguration<UserTable>
    {
        public UserConfiguration()
        {
            ToTable("logins");

            HasKey<int>(x => x.Identifier);

            Property<int>(x => x.Identifier)
                .HasColumnName("ID")
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.LastName)
                .HasColumnName("LastName")
                .IsVariableLength()
                .HasMaxLength(45)
                .IsRequired();
            Property(x => x.FirstName)
                .HasColumnName("FirstName")
                .IsVariableLength()
                .HasMaxLength(45)
                .IsOptional();
            Property(x => x.Username)
                .HasColumnName("Username")
                .IsVariableLength()
                .HasMaxLength(45)
                .IsRequired();
            Property(x => x.Password)
                .HasColumnName("Password")
                .IsVariableLength()
                .HasMaxLength(45)
                .IsRequired();
            Property(x => x.ModuleAccess)
                .HasColumnName("Module_Access")
                .IsVariableLength()
                .HasMaxLength(45)
                .IsOptional();
            Property(x => x.StaffId)
                .HasColumnName("Staff_ID")
                .IsVariableLength()
                .HasMaxLength(15)
                .IsOptional();
        }
    }
}
