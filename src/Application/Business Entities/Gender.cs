using System;
using System.Runtime.Serialization;

namespace CIS.Application.Entities
{
    [DataContract]
    public class Gender
    {
        private int _identifier;

        private string _description;

        [DataMember]
        public static readonly Gender MALE = new Gender(1, "Male");

        [DataMember]
        public static readonly Gender FEMALE = new Gender(2, "Female");

        [DataMember]
        public int Identifier
        {
            get
            {
                return _identifier;
            }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }

                _identifier = value;
            }
        }

        [DataMember]
        public string Description
        {
            get
            {
                return _description;
            }
            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }

                _description = value;
            }
        }

        public Gender(int identifier, string description)
        {
            Identifier = identifier;
            Description = description;
        }
    }
}
