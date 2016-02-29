using CIS.Data.DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace CIS.Data.Façade
{
    class DataServiceHost : ServiceHost
    {
        public DataServiceHost(Type t, params Uri[] baseAddresses)
            : base(t, baseAddresses)
        {
        }
    }
}
