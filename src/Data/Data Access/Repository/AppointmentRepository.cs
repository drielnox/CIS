using CIS.Application.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace CIS.Data.DataAccess.Repository
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private ClinicModel _context;

        public AppointmentRepository(ClinicModel context)
        {
            _context = context;
        }

        public int Add(Appointment entity)
        {
            _context.Appointments.Add(entity);
            return entity.Identifier;
        }

        public void Modify(Appointment entity)
        {
            _context.Appointments.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Remove(Appointment entity)
        {
            _context.Appointments.Remove(entity);
        }

        public Appointment GetById(int Id)
        {
            return _context.Appointments
                .Single(x => x.Identifier == Id);
        }

        public IEnumerable<Appointment> GetAll()
        {
            return _context.Appointments
                // .AsEnumerable();
                .ToList();
        }
    }
}
