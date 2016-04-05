using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace CIS.Application.Service.Contract
{
    [ServiceContract]
    public interface IPatientContract : IDisposable
    {
        [OperationContract]
        void AddPatient(Presentation.Model.Patients.NewPatientViewModel data);
        [OperationContract]
        IEnumerable<Presentation.Model.Common.ComboTitleViewModel> GetTitles();
        [OperationContract]
        IEnumerable<Presentation.Model.Common.ComboGenreViewModel> GetGenders();
        [OperationContract]
        IEnumerable<Presentation.Model.Common.ComboMaritalStatusViewModel> GetMaritalStatuses();
        [OperationContract]
        IEnumerable<Presentation.Model.Common.ComboNationalIdTypesViewModel> GetNationalIdTypes();
        [OperationContract]
        IEnumerable<Presentation.Model.Common.ComboKinRelationshipViewModel> GetKinRelations();
        [OperationContract]
        void UpdatePatient(Presentation.Model.Patients.EditPatientViewModel patient);
        [OperationContract]
        void DeletePatient(int patientId);
        [OperationContract]
        Presentation.Model.Patients.EditPatientViewModel GetPatient();
        [OperationContract]
        IEnumerable<Presentation.Model.Common.ClinicListViewModel> GetClinicians();
        [OperationContract]
        Presentation.Model.Patients.PatientsViewModel SearchPatients(Presentation.Model.Patients.SearchPatientViewModel criteria);
    }
}
