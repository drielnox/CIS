using CIS.Data.Service.Contract.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIS.Data.Service.Proxy.Repository
{
    class UserRepositoryProxy : IUserRepositoryContract
    {
        public int Add(Entities.UserTable entity)
        {
            throw new NotImplementedException();
        }

        public void Modify(Entities.UserTable entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Entities.UserTable entity)
        {
            throw new NotImplementedException();
        }

        public Entities.UserTable GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Entities.UserTable> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
