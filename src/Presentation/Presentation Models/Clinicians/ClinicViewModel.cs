using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CIS.Presentation.Model.Clinicians
{
    [DataContract]
    public class ClinicViewModel
    {
        [DataMember]
        public string InternalCode { get; set; }
        [DataMember]
        public int Identifier { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public object Title { get; set; }
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
    }
}
