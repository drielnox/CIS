using CIS.Data.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CIS.Data.DataAccess.Repository.Impl
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private ClinicModel _context;

        public AppointmentRepository(ClinicModel context)
        {
            _context = context;
        }

        public int Add(AppointmentTable entity)
        {
            _context.Appointments.Add(entity);
            return entity.Identifier;
        }

        public void Modify(AppointmentTable entity)
        {
            _context.Appointments.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Remove(AppointmentTable entity)
        {
            _context.Appointments.Remove(entity);
        }

        public AppointmentTable GetById(int Id)
        {
            return _context.Appointments
                .Single(x => x.Identifier == Id);
        }

        public IEnumerable<AppointmentTable> GetAll()
        {
            return _context.Appointments
                .AsEnumerable();
        }
    }
}
