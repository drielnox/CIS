using System.Runtime.Serialization;

namespace CIS.Presentation.Model.Common
{
    [DataContract]
    public class ComboTitleViewModel
    {
        [DataMember]
        public int Identifier { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}