
using CIS.Application.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CIS.Data.DataAccess.Repository
{
    public class MaritalStatusRepository : IMaritalStatusRepository
    {
        private ClinicModel _context;

        public MaritalStatusRepository(ClinicModel context)
        {
            _context = context;
        }

        public int Add(MaritalStatus entity)
        {
            _context.MaritalStatuses.Add(entity);
            return entity.Identifier;
        }

        public void Modify(MaritalStatus entity)
        {
            _context.MaritalStatuses.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Remove(MaritalStatus entity)
        {
            _context.MaritalStatuses.Remove(entity);
        }

        public MaritalStatus GetById(int Id)
        {
            return _context.MaritalStatuses
                .Single(x => x.Identifier == Id);
        }

        public IEnumerable<MaritalStatus> GetAll()
        {
            return _context.MaritalStatuses
                // .AsEnumerable();
                .ToList();
        }
    }
}
