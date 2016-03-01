
using CIS.Application.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CIS.Data.DataAccess.Repository
{
    class TitleRepository : ITitleRepository
    {
        private ClinicModel _context;

        public TitleRepository(ClinicModel context)
        {
            _context = context;
        }

        public int Add(Title entity)
        {
            _context.Titles.Add(entity);
            return entity.Identifier;
        }

        public void Modify(Title entity)
        {
            _context.Titles.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Remove(Title entity)
        {
            _context.Titles
                .Remove(entity);
        }

        public Title GetById(int Id)
        {
            return _context.Titles
                .Single(x => x.Identifier == Id);
        }

        public IEnumerable<Title> GetAll()
        {
            return _context.Titles
                // .AsEnumerable();
                .ToList();
        }
    }
}
