using CIS.Application.Service.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIS.Application.Service.Host
{
    internal class PatientServiceHost : DerivedServiceHost
    {
        public PatientServiceHost()
            : base(typeof(PatientProxy), new Uri("net.pipe://localhost/patientApp"))
        {
        }
    }
}
