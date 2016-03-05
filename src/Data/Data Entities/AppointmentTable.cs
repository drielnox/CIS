using System;
using System.Runtime.Serialization;

namespace CIS.Data.Entities
{
    [DataContract]
    public class AppointmentTable
    {
        [DataMember]
        public int Identifier { get; set; }
        [DataMember]
        public string ClinicianName { get; set; }
        [DataMember]
        public int PatientId { get; set; }
        [DataMember]
        public int HospitalNumber { get; set; }
        [DataMember]
        public string PatientName { get; set; }
        [DataMember]
        public DateTime Created { get; set; }
        [DataMember]
        public string Purpose { get; set; }
        [DataMember]
        public DateTime CreatedAt { get; set; }
    }
}
