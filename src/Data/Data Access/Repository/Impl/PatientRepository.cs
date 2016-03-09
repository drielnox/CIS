using CIS.Data.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CIS.Data.DataAccess.Repository.Impl
{
    public class PatientRepository : IPatientRepository
    {
        private ClinicModel _context;

        public PatientRepository(ClinicModel context)
        {
            _context = context;
        }

        public PatientTable GetById(int Id)
        {
            return _context.Patients
                .Single(x => x.Identifier == Id);
        }

        public IEnumerable<PatientTable> GetAll()
        {
            return _context.Patients
                .AsEnumerable();
        }

        public int Add(PatientTable entity)
        {
            _context.Patients.Add(entity);
            return entity.Identifier;
        }

        public void Modify(PatientTable entity)
        {
            _context.Patients.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Remove(PatientTable entity)
        {
            _context.Patients.Remove(entity);
        }
    }
}
