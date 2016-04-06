using CIS.Application.Service.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace CIS.Application.Service.Host
{
    internal class ClinicianServiceHost : DerivedServiceHost
    {
        public ClinicianServiceHost()
            : base(typeof(ClinicianProxy), new Uri("net.pipe://localhost/clinicianApp"))
        {
        }
    }
}
