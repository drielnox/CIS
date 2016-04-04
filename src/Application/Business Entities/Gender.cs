using CIS.Transversal.SharedKernel;
using System;
using System.Linq;
using System.Runtime.Serialization;

namespace CIS.Application.Entities
{
    [DataContract]
    public class Gender : Entity
    {
        private int _identifier;

        private string _description;

        [DataMember]
        public static readonly Gender MALE = new Gender(1, "Male");

        [DataMember]
        public static readonly Gender FEMALE = new Gender(2, "Female");

        [DataMember]
        public override int Identifier
        {
            get
            {
                return _identifier;
            }
            protected set
            {
                if (value < 0)
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

                if (value.Any(c => char.IsDigit(c)))
                {
                    throw new ArgumentException();
                }

                if (value.Any(c => char.IsControl(c) || char.IsSeparator(c) || char.IsSymbol(c)))
                {
                    throw new ArgumentException();
                }

                if (value.Any(c => char.IsPunctuation(c)))
                {
                    throw new ArgumentException();
                }

                _description = value;
            }
        }

        public Gender(int identifier, string description)
            : base(identifier)
        {
            Description = description;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            var gender = obj as Gender;

            return Identifier.Equals(gender.Identifier) &&
                Description.Equals(gender.Description) &&
                base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
