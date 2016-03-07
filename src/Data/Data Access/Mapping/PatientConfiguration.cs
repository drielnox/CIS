using CIS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace CIS.Data.DataAccess.Mapping
{
    internal class PatientConfiguration : EntityTypeConfiguration<PatientTable>
    {
        public PatientConfiguration()
        {

        }
    }
}
