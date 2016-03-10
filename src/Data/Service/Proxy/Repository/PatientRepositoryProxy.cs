using CIS.Data.DataAccess.Repository;
using CIS.Data.Entities;
using CIS.Data.Service.Contract.Repository;
using System.Collections.Generic;
using System.ServiceModel;

namespace CIS.Data.Service.Proxy.Repository
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    class PatientRepositoryProxy : IPatientRepositoryContract
    {
        private IPatientRepository _repo;

        public PatientRepositoryProxy(IPatientRepository repo)
        {
            _repo = repo;
        }

        public int Add(PatientTable entity)
        {
            return _repo.Add(entity);
        }

        public void Modify(PatientTable entity)
        {
            _repo.Modify(entity);
        }

        public void Remove(PatientTable entity)
        {
            _repo.Remove(entity);
        }

        public PatientTable GetById(int id)
        {
            return _repo.GetById(id);
        }

        public IEnumerable<PatientTable> GetAll()
        {
            return _repo.GetAll();
        }
    }
}
