using CIS.Data.DataAccess.Repository;
using CIS.Data.Entities;
using CIS.Data.Service.Contract.Repository;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace CIS.Data.Service.Proxy.Repository
{
    public class AppointmentRepositoryProxy : IAppointmentRepositoryContract
    {
        private IAppointmentRepository _repo;

        public AppointmentRepositoryProxy(IAppointmentRepository repo)
        {
            _repo = repo;
        }

        public int Add(AppointmentTable entity)
        {
            return _repo.Add(entity);
        }

        public void Modify(AppointmentTable entity)
        {
            _repo.Modify(entity);
        }

        public void Remove(AppointmentTable entity)
        {
            _repo.Remove(entity);
        }

        public AppointmentTable GetById(int id)
        {
            return _repo.GetById(id);
        }

        public IEnumerable<AppointmentTable> GetAll()
        {
            return _repo.GetAll();
        }
    }
}
