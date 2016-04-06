using System.Runtime.Serialization;

namespace CIS.Presentation.Model
{
    [DataContract]
    public class NewClinicPresentationModel
    {
        [DataMember]
        public string InternalCode { get; set; }
        [DataMember]
        public int Title { get; set; }
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
    }
}
