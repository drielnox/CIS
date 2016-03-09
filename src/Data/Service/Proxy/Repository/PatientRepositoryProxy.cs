using CIS.Data.Entities;
using CIS.Data.Service.Contract.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIS.Data.Service.Proxy.Repository
{
    class PatientRepositoryProxy : IPatientRepositoryContract
    {
        public int Add(PatientTable entity)
        {
            throw new NotImplementedException();
        }

        public void Modify(PatientTable entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(PatientTable entity)
        {
            throw new NotImplementedException();
        }

        public PatientTable GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PatientTable> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
