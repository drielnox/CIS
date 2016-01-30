
namespace CIS.Application.Entities
{
    public class Gender
    {
        public static readonly Gender MALE = new Gender(1, "Male");
        public static readonly Gender FEMALE = new Gender(2, "Female");

        public int Identifier { get; protected set; }
        public string Description { get; protected set; }

        public Gender(int identifier, string description)
        {
            Identifier = identifier;
            Description = description;
        }
    }
}
