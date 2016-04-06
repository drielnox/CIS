using CIS.Application.Service.Contract;
using CIS.Presentation.Model.Common;
using CIS.Presentation.Model.Patients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIS.Application.Service.Proxy
{
    public class PatientProxy : IPatientContract
    {
        public void AddPatient(NewPatientViewModel data)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ComboTitleViewModel> GetTitles()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ComboGenreViewModel> GetGenders()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ComboMaritalStatusViewModel> GetMaritalStatuses()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ComboNationalIdTypesViewModel> GetNationalIdTypes()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ComboKinRelationshipViewModel> GetKinRelations()
        {
            throw new NotImplementedException();
        }

        public void UpdatePatient(EditPatientViewModel patient)
        {
            throw new NotImplementedException();
        }

        public void DeletePatient(int patientId)
        {
            throw new NotImplementedException();
        }

        public EditPatientViewModel GetPatient()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClinicListViewModel> GetClinicians()
        {
            throw new NotImplementedException();
        }

        public PatientsViewModel SearchPatients(SearchPatientViewModel criteria)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
