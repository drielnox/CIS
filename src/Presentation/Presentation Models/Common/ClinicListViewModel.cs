using System.Runtime.Serialization;

namespace CIS.Presentation.Model.Common
{
    [DataContract]
    public class ClinicListViewModel
    {
        [DataMember]
        public int Identifier { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
    }
}
