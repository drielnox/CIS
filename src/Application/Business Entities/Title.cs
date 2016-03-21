
namespace CIS.Application.Entities
{
    public class Title
    {
        public static readonly Title MR = new Title(1, "Mr");
        public static readonly Title MRS = new Title(2, "Mrs");
        public static readonly Title MISS = new Title(3, "Miss");

        public int Identifier { get; set; }
        public string Abbreviation { get; set; }
        public string Description { get; set; }

        public Title(int identifier, string description)
        {
            Identifier = identifier;
            Description = description;
        }
    }
}
