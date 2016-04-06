using CIS.Application.Service.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIS.Application.Service.Host
{
    internal class AppointmentServiceHost : DerivedServiceHost
    {
        public AppointmentServiceHost()
            : base(typeof(AppointmentProxy), new Uri("net.pipe://localhost/appointmentApp"))
        {
        }
    }
}
