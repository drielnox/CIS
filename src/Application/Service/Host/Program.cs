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
        static void Main(string[] args)
        {
            ServiceHost host = null;

            try
            {
                host = new ServiceHost(typeof(ConfigurationProxy), new Uri("net.pipe://localhost/app"));

                host.Opening += new EventHandler((o, e) => Console.WriteLine("Opening"));
                host.Opened += new EventHandler((o, e) => Console.WriteLine("Opened"));
                host.Closing += new EventHandler((o, e) => Console.WriteLine("Closing"));
                host.Closed += new EventHandler((o, e) => Console.WriteLine("Closed"));
                host.UnknownMessageReceived += new EventHandler<UnknownMessageReceivedEventArgs>((o, e) => Console.WriteLine("UnknownMessageReceived: {0}", e.Message));
                host.Faulted += new EventHandler((o, e) => Console.WriteLine("Faulted"));

                host.Open();

                Console.ReadLine();

                host.Close();
            }
            catch (TimeoutException tex)
            {
                Console.WriteLine(tex.Message);
                host.Abort();
            }
            catch (CommunicationObjectFaultedException cofex)
            {
                Console.WriteLine(cofex.Message);
                host.Abort();
            }
            catch (ObjectDisposedException odex)
            {
                Console.WriteLine(odex.Message);
                host.Abort();
            }
            catch (InvalidOperationException ioex)
            {
                Console.WriteLine(ioex.Message);
                host.Abort();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                host.Abort();
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
