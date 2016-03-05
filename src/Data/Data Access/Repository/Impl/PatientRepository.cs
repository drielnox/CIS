using CIS.Application.Entities;
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

        public Patient GetById(int Id)
        {
            return _context.Patients
                .Single(x => x.Identifier == Id);
        }

        public IEnumerable<Patient> GetAll()
        {
            return _context.Patients
                .AsEnumerable();
        }

        public int Add(Patient entity)
        {
            _context.Patients.Add(entity);
            return entity.Identifier;
        }

        public void Modify(Patient entity)
        {
            _context.Patients.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Remove(Patient entity)
        {
            _context.Patients.Remove(entity);
        }
    }
}
