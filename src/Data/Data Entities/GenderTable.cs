using System;
using System.Runtime.Serialization;

namespace CIS.Data.Entities
{
    [DataContract]
    public class GenderTable
    {
        [DataMember]
        public int Identifier { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}
