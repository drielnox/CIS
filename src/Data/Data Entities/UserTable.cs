using System.Runtime.Serialization;

namespace CIS.Data.Entities
{
    [DataContract]
    public class UserTable
    {
        [DataMember]
        public int Identifier { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string ModuleAccess { get; set; }
    }
}
