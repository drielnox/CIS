
using CIS.Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CIS.Application.BusinessComponents
{
    public class AppointmentBusinessLogic : IDisposable
    {
#if !DEBUG
        private IUnitOfWork _unitOfWork;
#endif
        public AppointmentBusinessLogic()
        {
#if !DEBUG
            _unitOfWork = new UnitOfWork();
#endif
        }

        public void AddAppointment(Appointment ap)
        {
#if !DEBUG
            var appointment = new Appointment
            {
                ClinicianName = ap.ClinicianName,
                Created = ap.Created,
            };

            _unitOfWork.AppointmentRepository.Add(appointment);
            _unitOfWork.Save();
#endif

        }

        public IEnumerable<Appointment> GetAppointments()
        {
#if !DEBUG
            return _unitOfWork.AppointmentRepository
                .GetAll()
                .Select(x => new ViewAppointmentViewModel
                {
                    AppointmentDate = x.Created,
                    AppointmentId = x.Identifier,
                    ClinicianId = 0, // TODO: search the way to obtaian the clinic id
                    ClinicianName = x.ClinicianName,
                    HospitalNumber = x.HospitalNumber,
                    PatientId = x.PatientId,
                    PatientName = x.PatientName,
                    Purpose = x.Purpose
                });
#else
            return null;
#endif
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
#if !DEBUG
            if (disposing)
            {
                _unitOfWork.Dispose();
                _unitOfWork = null;
            }
#endif
        }
    }
}
