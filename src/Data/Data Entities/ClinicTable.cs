using System;
using System.Runtime.Serialization;

namespace CIS.Data.Entities
{
    [DataContract]
    public class ClinicTable
    {
        [DataMember]
        public int Identifier { get; set; }
        [DataMember]
        public string InternalCode { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string Specialty { get; set; }
        [DataMember]
        public string Department { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string Telephone { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public DateTime CreatedAt { get; set; }
        [DataMember]
        public DateTime? ModifiedAt { get; set; }
    }
}
