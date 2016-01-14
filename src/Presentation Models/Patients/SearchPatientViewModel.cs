using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIS.Presentation.Model.Patients
{
    public class SearchPatientViewModel
    {
        public string PatientId { get; set; }

        public string HospitalNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
