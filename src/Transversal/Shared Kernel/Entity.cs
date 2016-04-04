using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIS.Transversal.SharedKernel
{
    public abstract class Entity : IEntity
    {
        public abstract int Identifier { get; protected set; }

        protected Entity(int id)
        {
            Identifier = id;
        }

        public override bool Equals(object obj)
        {
            var entity = obj as Entity;
            if (entity == null)
            {
                return false;
            }

            return Identifier.Equals(entity.Identifier);
        }

        public override int GetHashCode()
        {
            return Identifier;
        }
    }
}
