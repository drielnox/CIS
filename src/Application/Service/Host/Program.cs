using CIS.Application.Service.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace CIS.Application.Service.Host
{
    class Program
    {
        private static IEnumerable<ServiceHost> hosts;

        static void Main(string[] args)
        {
            try
            {
                hosts = new List<ServiceHost>
                {
                    new AdministrationServiceHost(),
                    new AppointmentServiceHost(),
                    new ClinicianServiceHost(),
                    new ConfigurationServiceHost(),
                    new PatientServiceHost()
                };

                foreach (ServiceHost host in hosts)
                {
                    host.UnknownMessageReceived += new EventHandler<UnknownMessageReceivedEventArgs>((o, e) => Console.WriteLine("UnknownMessageReceived: {0}", e.Message));
                    host.Open();
                }

                Console.ReadLine();

                foreach (DerivedServiceHost host in hosts)
                {
                    host.Close();
                }
            }
            catch (TimeoutException tex)
            {
                Console.WriteLine(tex.Message);
                AbortHosts();
            }
            catch (CommunicationObjectFaultedException cofex)
            {
                Console.WriteLine(cofex.Message);
                AbortHosts();
            }
            catch (ObjectDisposedException odex)
            {
                Console.WriteLine(odex.Message);
                AbortHosts();
            }
            catch (InvalidOperationException ioex)
            {
                Console.WriteLine(ioex.Message);
                AbortHosts();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                AbortHosts();
            }
            finally
            {
                Console.ReadLine();
            }
        }

        private static void AbortHosts()
        {
            foreach (DerivedServiceHost host in hosts)
            {
                host.Abort();
            }
        }
    }
}
