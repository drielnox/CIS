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
        public string ClinicianId { get; set; }
        [DataMember]
        public string ClinicianName { get; set; }
        [DataMember]
        public int PatientId { get; set; }
        [DataMember]
        public string HospitalNumber { get; set; }
        [DataMember]
        public string PatientName { get; set; }
        [DataMember]
        public DateTime DateCreated { get; set; }
        [DataMember]
        public DateTime TimeCreated { get; set; }
        [DataMember]
        public string Purpose { get; set; }
        [DataMember]
        public DateTime CreatedAt { get; set; }
        [DataMember]
        public string PatientAttented { get; set; }
        [DataMember]
        public DateTime? Arrived { get; set; }
        [DataMember]
        public DateTime? Departed { get; set; }
        [DataMember]
        public string Result { get; set; }
        [DataMember]
        public DateTime? ModifiedAt { get; set; }
    }
}
