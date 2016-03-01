
using System;

namespace CIS.Presentation.Model.Appointment
{
    public class BookAppointmentViewModel
    {
        public int Identifier { get; set; }

        public string ClinicianName { get; set; }

        public int PatientId { get; set; }

        public int HospitalNumber { get; set; }

        public string PatientName { get; set; }

        public DateTime Created { get; set; }

        public string Purpose { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
