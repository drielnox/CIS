using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CIS.Presentation.Model.Patients
{
    [DataContract]
    public class PatientsViewModel
    {
        [DataMember]
        public IEnumerable<PatientViewModel> Patients { get; set; }

        public PatientsViewModel()
        {
            Patients = new List<PatientViewModel>();
        }
    }
}
