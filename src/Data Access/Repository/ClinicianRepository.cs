using System;
using System.Collections.Generic;

namespace CIS.Data.DataAccess.Repository
{
    public class ClinicianRepository : IClinicianRepository
    {
        private ClinicModel _context;

        public ClinicianRepository(ClinicModel context)
        {
            _context = context;
        }
        public int Add(Application.Entities.Clinic entity)
        {
            throw new NotImplementedException();
        }

        public void Modify(Application.Entities.Clinic entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Application.Entities.Clinic entity)
        {
            throw new NotImplementedException();
        }

        public Application.Entities.Clinic GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Application.Entities.Clinic> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
