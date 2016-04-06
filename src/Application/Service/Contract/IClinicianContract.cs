using CIS.Presentation.Model;
using CIS.Presentation.Model.Clinicians;
using CIS.Presentation.Model.Common;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace CIS.Application.Service.Contract
{
    [ServiceContract]
    public interface IClinicianContract : IDisposable
    {
        [OperationContract]
        IEnumerable<ComboTitleViewModel> GetTitles();
        [OperationContract]
        IEnumerable<ClinicListViewModel> GetClinicians();
        [OperationContract]
        void AddClinic(NewClinicPresentationModel model);
        [OperationContract]
        void UpdateClinic(EditClinicViewModel data);
    }
}
