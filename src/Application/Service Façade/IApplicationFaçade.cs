using CIS.Application.BusinessComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace CIS.Application.Façade
{
    [ServiceContract]
    public interface IApplicationFaçade : IDisposable
    {
        GenreBusinessLogic Genre
        { 
            [OperationContract]
            get;
        }
    }
}
