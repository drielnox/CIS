using System.Runtime.Serialization;

namespace CIS.Presentation.Model.Patients
{
    [DataContract]
    public class SearchPatientViewModel
    {
        [DataMember]
        public string PatientId { get; set; }
        [DataMember]
        public string HospitalNumber { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
    }
}
