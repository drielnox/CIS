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
    class UserRepositoryProxy : IUserRepositoryContract
    {
        private IUserRepository _repo;

        public UserRepositoryProxy(IUserRepository repo)
        {
            _repo = repo;
        }
        
        public int Add(UserTable entity)
        {
            return _repo.Add(entity);
        }

        public void Modify(UserTable entity)
        {
            _repo.Modify(entity);
        }

        public void Remove(UserTable entity)
        {
            _repo.Remove(entity);
        }

        public UserTable GetById(int id)
        {
            return _repo.GetById(id);
        }

        public IEnumerable<UserTable> GetAll()
        {
            return _repo.GetAll();
        }
    }
}
