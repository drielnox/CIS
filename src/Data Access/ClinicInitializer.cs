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

            List<Title> titles = new List<Title> 
            { 
                new Title { Description = "Mr" },
                new Title { Description = "Mrs" },
                new Title { Description = "Miss" },
            };

            context.Titles.AddRange(titles);

            base.Seed(context);
        }
    }
}
