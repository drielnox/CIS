using CIS.Presentation.Model.Administration;
using CIS.Presentation.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace CIS.Application.Service.Contract
{
    [ServiceContract]
    public interface IAdministrationContract : IDisposable
    {
        [OperationContract]
        void ChangePassword(ChangeUserPasswordViewModel data);
        [OperationContract]
        void Save(NewUserViewModel data);
        [OperationContract]
        IEnumerable<ClinicListViewModel> GetClinicians();
        [OperationContract]
        UserViewModel GetUsers();
    }
}
