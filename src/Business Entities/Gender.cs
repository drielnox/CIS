
namespace CIS.Application.Entities
{
    public class Gender
    {
        public readonly Gender MALE = new Gender(1, "Male");
        public readonly Gender FEMALE = new Gender(1, "Female");

        public int Identifier { get; protected set; }
        public string Description { get; protected set; }

        public Gender(int identifier, string description)
        {
            Identifier = identifier;
            Description = description;
        }
    }
}
