using System.Runtime.Serialization;

namespace CIS.Presentation.Model.Common
{
    [DataContract]
    public class ComboGenreViewModel
    {
        [DataMember]
        public int Identifier { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}
