using CIS.Presentation.Model.Common;
using CIS.Presentation.Model.Patients;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace CIS.Application.Service.Contract
{
    [ServiceContract]
    public interface IPatientContract : IDisposable
    {
        [OperationContract]
        void AddPatient(NewPatientViewModel data);
        [OperationContract]
        IEnumerable<ComboTitleViewModel> GetTitles();
        [OperationContract]
        IEnumerable<ComboGenreViewModel> GetGenders();
        [OperationContract]
        IEnumerable<ComboMaritalStatusViewModel> GetMaritalStatuses();
        [OperationContract]
        IEnumerable<ComboNationalIdTypesViewModel> GetNationalIdTypes();
        [OperationContract]
        IEnumerable<ComboKinRelationshipViewModel> GetKinRelations();
        [OperationContract]
        void UpdatePatient(EditPatientViewModel patient);
        [OperationContract]
        void DeletePatient(int patientId);
        [OperationContract]
        EditPatientViewModel GetPatient();
        [OperationContract]
        IEnumerable<ClinicListViewModel> GetClinicians();
        [OperationContract]
        PatientsViewModel SearchPatients(SearchPatientViewModel criteria);
    }
}
