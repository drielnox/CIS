using System.Runtime.Serialization;

namespace CIS.Application.Entities
{
    [DataContract]
    public class Gender
    {
        [DataMember]
        public static readonly Gender MALE = new Gender(1, "Male");

        [DataMember]
        public static readonly Gender FEMALE = new Gender(2, "Female");

        [DataMember]
        public int Identifier { get; protected set; }

        [DataMember]
        public string Description { get; protected set; }

        public Gender(int identifier, string description)
        {
            Identifier = identifier;
            Description = description;
        }
    }
}
