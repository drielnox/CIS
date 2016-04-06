using System;
using System.Runtime.Serialization;

namespace CIS.Presentation.Model.Patients
{
    [DataContract]
    public class NewPatientViewModel
    {
        [DataMember]
        public string HospitalNumber { get; set; }
        [DataMember]
        public int Title { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string OtherName { get; set; }
        [DataMember]
        public int Gender { get; set; }
        [DataMember]
        public DateTime BirthDate { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public string HomeAddress { get; set; }
        [DataMember]
        public int MaritalStatus { get; set; }
    }
}
