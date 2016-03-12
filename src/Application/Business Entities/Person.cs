using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIS.Application.Entities
{
    abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Title Title { get; set; }
        public int Telephone { get; set; }
        public string Email { get; set; }
    }
}
