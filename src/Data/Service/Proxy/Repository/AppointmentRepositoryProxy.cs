using CIS.Data.Entities;
using CIS.Data.Service.Contract.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIS.Data.Service.Proxy.Repository
{
    public class AppointmentRepositoryService : IAppointmentRepositoryContract
    {
        public int Add(AppointmentTable entity)
        {
            throw new NotImplementedException();
        }

        public void Modify(AppointmentTable entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(AppointmentTable entity)
        {
            throw new NotImplementedException();
        }

        public AppointmentTable GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AppointmentTable> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
