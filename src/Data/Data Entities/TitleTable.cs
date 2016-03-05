
using System.Runtime.Serialization;

namespace CIS.Data.Entities
{
    [DataContract]
    public class TitleTable
    {
        [DataMember]
        public int Identifier { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}
