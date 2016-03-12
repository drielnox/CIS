using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace CIS.Data.Service.Contract.UnitOfWork
{
    [ServiceContract]
    public interface IGenericUnitOfWorkContract : IDisposable
    {
        [OperationContract]
        void Save();
    }
}
