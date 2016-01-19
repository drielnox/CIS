using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIS.Presentation.Model.Patients
{
    public class NewPatientViewModel
    {
        public string HospitalNumber { get; set; }

        public int Title { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string OtherName { get; set; }

        public int Gender { get; set; }

        public DateTime BirthDate { get; set; }

        public string Phone { get; set; }

        public string HomeAddress { get; set; }

        public int MaritalStatus { get; set; }
    }
}
