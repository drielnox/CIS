using CIS.Transversal.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIS.Application.Entities
{
    public class PersonRelationship : Entity
    {
        public override int Identifier { get; protected set; }

        public PersonRelationship(int identifier)
            : base(identifier)
        {

        }
    }
}
