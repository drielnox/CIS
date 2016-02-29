using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace CIS.Application.Façade
{
    class ApplicationServiceHost : ServiceHost
    {
        public ApplicationServiceHost(Type t, params Uri[] baseAddresses)
            : base(t, baseAddresses)
        {
        }
    }
}
