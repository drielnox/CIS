using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace CIS.Application.Entities
{
    [DataContract]
    public class Appointment
    {
        [DataMember]
        public int Identifier { get; set; }
        [DataMember]
        public string ClinicianName { get; set; }
        [DataMember]
        public int PatientId { get; set; }
        [DataMember]
        public Hospital HospitalNumber { get; set; }
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
