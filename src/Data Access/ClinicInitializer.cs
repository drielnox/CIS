using CIS.Application.Entities;
using System.Collections.Generic;
using System.Data.Entity;

namespace CIS.Data.DataAccess
{
    class ClinicInitializer : DropCreateDatabaseAlways<ClinicModel>
    {
        protected override void Seed(ClinicModel context)
        {
            User exampleUser = new User()
            {
                FirstName = "John",
                LastName = "Smith",
                Username = "jsmith",
                Password = "password"
            };

            context.Users.Add(exampleUser);

            List<Gender> genders = new List<Gender>
            {
                Gender.MALE,
                Gender.FEMALE
            };

            context.Genders.AddRange(genders);

            List<Title> titles = new List<Title> 
            { 
                Title.MR,
                Title.MRS,
                Title.MISS
            };

            context.Titles.AddRange(titles);

            List<MaritalStatus> maritalStatuses = new List<MaritalStatus>
            {
                MaritalStatus.SINGLE,
                MaritalStatus.MARRIED,
                MaritalStatus.DIVORCED,
                MaritalStatus.WIDOWED
            };

            context.MaritalStatuses.AddRange(maritalStatuses);

            base.Seed(context);
        }
    }
}
