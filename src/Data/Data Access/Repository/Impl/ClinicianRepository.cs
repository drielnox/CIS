using CIS.Data.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CIS.Data.DataAccess.Repository.Impl
{
    public class ClinicianRepository : IClinicianRepository
    {
        private ClinicModel _context;

        public ClinicianRepository(ClinicModel context)
        {
            _context = context;
        }
        public int Add(ClinicTable entity)
        {
            _context.Clinicians.Add(entity);
            return entity.Identifier;
        }

        public void Modify(ClinicTable entity)
        {
            _context.Clinicians.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Remove(ClinicTable entity)
        {
            _context.Clinicians.Remove(entity);
        }

        public ClinicTable GetById(int Id)
        {
            return _context.Clinicians
                .Single(x => x.Identifier == Id);
        }

        public IEnumerable<ClinicTable> GetAll()
        {
            return _context.Clinicians
                .AsEnumerable();
        }
    }
}
