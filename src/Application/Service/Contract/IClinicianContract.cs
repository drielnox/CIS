using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace CIS.Application.Service.Contract
{
    [ServiceContract]
    public interface IClinicianContract : IDisposable
    {
        [OperationContract]
        IEnumerable<Presentation.Model.Common.ComboTitleViewModel> GetTitles();
        [OperationContract]
        void UpdateClinic(Presentation.Model.Clinicians.EditClinicViewModel data);
        [OperationContract]
        void AddClinic(Presentation.Model.NewClinicPresentationModel model);
    }
}
