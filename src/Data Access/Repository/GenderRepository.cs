
using CIS.Application.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CIS.Data.DataAccess.Repository
{
    public class GenderRepository : IGenderRepository
    {
        private ClinicModel _context;

        public GenderRepository(ClinicModel context)
        {
            _context = context;
        }

        public int Add(Gender entity)
        {
            _context.Genders.Add(entity);
            return entity.Identifier;
        }

        public void Modify(Gender entity)
        {
            _context.Genders.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Remove(Gender entity)
        {
            _context.Genders.Remove(entity);
        }

        public Gender GetById(int Id)
        {
            return _context.Genders
                .Single(x => x.Identifier == Id);
        }

        public IEnumerable<Gender> GetAll()
        {
            return _context.Genders
                // .AsEnumerable();
                .ToList();
        }
    }
}
