using System;

namespace CIS.Presentation.Model.Appointment
{
    public class ViewAppointmentViewModel
    {
        public int AppointmentId { get; set; }
        public int ClinicianId { get; set; }
        public string ClinicianName { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int PatientId { get; set; }
        public int HospitalNumber { get; set; }
        public string PatientName { get; set; }
        public string Purpose { get; set; }
    }
}
