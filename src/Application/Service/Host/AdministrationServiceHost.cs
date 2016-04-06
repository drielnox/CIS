using CIS.Application.Service.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIS.Application.Service.Host
{
    internal class AdministrationServiceHost : DerivedServiceHost
    {
        public AdministrationServiceHost()
            : base(typeof(AdministrationProxy), new Uri("net.pipe://localhost/admisnitrationApp"))
        {
        }
    }
}
