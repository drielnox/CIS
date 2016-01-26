
using CIS.Application.Entities;
using CIS.Data.DataAccess.UnitOfWork;
using CIS.Presentation.Model.Appointment;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CIS.Application.BusinessComponents
{
    public class AppointmentBusinessLogic : IDisposable
    {
        private IUnitOfWork _unitOfWork;

        public AppointmentBusinessLogic()
        {
            _unitOfWork = new UnitOfWork();
        }

        public void AddAppointment(BookAppointmentViewModel ap)
        {
            var appointment = new Appointment
            {
                ClinicianName = ap.ClinicianName,
                Created = ap.Created,
            };

            _unitOfWork.AppointmentRepository.Add(appointment);
            _unitOfWork.Save();
        }

        public IEnumerable<ViewAppointmentViewModel> GetAppointments()
        {
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
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
                _unitOfWork = null;
            }
        }
    }
}
