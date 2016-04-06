using System.Runtime.Serialization;

namespace CIS.Presentation.Model.Patients
{
    [DataContract]
    public class PatientViewModel
    {
        [DataMember]
        public string Identifier { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
    }
}
