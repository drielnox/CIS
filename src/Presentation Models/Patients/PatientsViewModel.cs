using System.Collections.Generic;

namespace CIS.Presentation.Model.Patients
{
    public class PatientsViewModel
    {
        public IEnumerable<PatientViewModel> Patients { get; set; }

        public PatientsViewModel()
        {
            Patients = new List<PatientViewModel>();
        }
    }
}
