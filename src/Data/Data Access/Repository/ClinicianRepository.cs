using CIS.Application.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CIS.Data.DataAccess.Repository
{
    public class ClinicianRepository : IClinicianRepository
    {
        private ClinicModel _context;

        public ClinicianRepository(ClinicModel context)
        {
            _context = context;
        }
        public int Add(Clinic entity)
        {
            _context.Clinicians.Add(entity);
            return entity.Identifier;
        }

        public void Modify(Clinic entity)
        {
            _context.Clinicians.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Remove(Clinic entity)
        {
            _context.Clinicians.Remove(entity);
        }

        public Clinic GetById(int Id)
        {
            return _context.Clinicians
                .Single(x => x.Identifier == Id);
        }

        public IEnumerable<Clinic> GetAll()
        {
            return _context.Clinicians
                // .AsEnumerable();
                .ToList();
        }
    }
}
