
namespace CIS.Application.Entities
{
    public class MaritalStatus
    {
        public static readonly MaritalStatus SINGLE = new MaritalStatus(1, "Single");
        public static readonly MaritalStatus MARRIED = new MaritalStatus(2, "Married");
        public static readonly MaritalStatus DIVORCED = new MaritalStatus(3, "Divorced");
        public static readonly MaritalStatus WIDOWED = new MaritalStatus(4, "Widowed");

        public int Identifier { get; protected set; }
        public string Abbreviation { get; set; }
        public string Description { get; protected set; }

        public MaritalStatus(int identifier, string description)
        {
            Identifier = identifier;
            Description = description;
        }

        public MaritalStatus(int identifier, string abbreviation, string description)
            : this(identifier, description)
        {
            Abbreviation = abbreviation;
        }
    }
}
