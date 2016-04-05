using System.Runtime.Serialization;

namespace CIS.Presentation.Model.Administration.MaritalStatus
{
    [DataContract]
    [KnownType(typeof(ListItemMaritalStatusViewModel))]
    public class MaritalStatusViewModel
    {
        [DataMember]
        public int Identifier { get; set; }
        [DataMember]
        public string Abbreviation { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}
