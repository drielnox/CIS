using CIS.Presentation.Model.Administration;
using CIS.Presentation.Model.Common;
using System;
using System.Collections.Generic;
using System.ServiceModel;

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
        UsersViewModel GetUsers();
    }
}
