using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIS.Data.DataAccess.Repository
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private ClinicModel _context;

        public AppointmentRepository(ClinicModel context)
        {
            _context = context;
        }
        public int Add(Application.Entities.Appointment entity)
        {
            throw new NotImplementedException();
        }

        public void Modify(Application.Entities.Appointment entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Application.Entities.Appointment entity)
        {
            throw new NotImplementedException();
        }

        public Application.Entities.Appointment GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Application.Entities.Appointment> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
