using CIS.Application.Service.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace CIS.Application.Service.Host
{
    internal class ConfigurationServiceHost : DerivedServiceHost
    {
        public ConfigurationServiceHost()
            : base(typeof(ConfigurationProxy), new Uri("net.pipe://localhost/configurationApp"))
        {
        }
    }
}
