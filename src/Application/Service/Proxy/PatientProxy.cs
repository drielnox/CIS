using CIS.Application.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIS.Application.Service.Proxy
{
    public class PatientProxy : IPatientContract
    {
        public void AddPatient(Presentation.Model.Patients.NewPatientViewModel data)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Presentation.Model.Common.ComboTitleViewModel> GetTitles()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Presentation.Model.Common.ComboGenreViewModel> GetGenders()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Presentation.Model.Common.ComboMaritalStatusViewModel> GetMaritalStatuses()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Presentation.Model.Common.ComboNationalIdTypesViewModel> GetNationalIdTypes()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Presentation.Model.Common.ComboKinRelationshipViewModel> GetKinRelations()
        {
            throw new NotImplementedException();
        }

        public void UpdatePatient(Presentation.Model.Patients.EditPatientViewModel patient)
        {
            throw new NotImplementedException();
        }

        public void DeletePatient(int patientId)
        {
            throw new NotImplementedException();
        }

        public Presentation.Model.Patients.EditPatientViewModel GetPatient()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Presentation.Model.Common.ClinicListViewModel> GetClinicians()
        {
            throw new NotImplementedException();
        }

        public Presentation.Model.Patients.PatientsViewModel SearchPatients(Presentation.Model.Patients.SearchPatientViewModel criteria)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
