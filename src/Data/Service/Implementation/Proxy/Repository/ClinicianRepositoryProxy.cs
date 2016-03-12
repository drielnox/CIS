using CIS.Data.DataAccess.Repository;
using CIS.Data.Entities;
using CIS.Data.Service.Contract.Repository;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace CIS.Data.Service.Proxy.Repository
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    [DataContract]
    class ClinicianRepositoryProxy : IClinicianRepositoryContract
    {
        private IClinicianRepository _repo;

        public ClinicianRepositoryProxy(IClinicianRepository repo)
        {
            _repo = repo;
        }
        public int Add(ClinicTable entity)
        {
            return _repo.Add(entity);
        }

        public void Modify(ClinicTable entity)
        {
            _repo.Modify(entity);
        }

        public void Remove(ClinicTable entity)
        {
            _repo.Remove(entity);
        }

        public ClinicTable GetById(int id)
        {
            return _repo.GetById(id);
        }

        public IEnumerable<ClinicTable> GetAll()
        {
            return _repo.GetAll();
        }
    }
}
