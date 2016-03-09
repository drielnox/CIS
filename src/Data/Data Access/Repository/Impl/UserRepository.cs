using CIS.Data.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CIS.Data.DataAccess.Repository.Impl
{
    internal class UserRepository : IUserRepository
    {
        private ClinicModel _context;

        public UserRepository(ClinicModel context)
        {
            _context = context;
        }

        public int Add(UserTable entity)
        {
            _context.Users.Add(entity);
            return entity.Identifier;
        }

        public void Modify(UserTable entity)
        {
            _context.Users.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Remove(UserTable entity)
        {
            _context.Users.Remove(entity);
        }

        public UserTable GetById(int Id)
        {
            return _context.Users
                .Single(x => x.Identifier == Id);
        }

        public IEnumerable<UserTable> GetAll()
        {
            return _context.Users
                .AsEnumerable();
        }
    }
}
