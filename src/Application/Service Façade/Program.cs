using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace CIS.Application.Façade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (ServiceHost host = new ServiceHost(typeof(ApplicationFaçade)))
                {
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
            }
            catch (CommunicationObjectFaultedException cofex)
            {
                Console.WriteLine("{0}", cofex.Message);
                Console.WriteLine("{0}", cofex.StackTrace);
            }
            catch (AddressAlreadyInUseException aaiuex)
            {
                Console.WriteLine("{0}", aaiuex.Message);
                Console.WriteLine("{0}", aaiuex.StackTrace);
            }
            finally
            {
                Console.ReadLine();
            }

            //try
            //{
            //    using (ApplicationServiceHost host = new ApplicationServiceHost(typeof(ApplicationFaçade)))
            //    {
            //        host.Opening += new EventHandler((o, e) => Console.WriteLine("Opening"));
            //        host.Opened += new EventHandler((o, e) => Console.WriteLine("Opened"));
            //        host.Closing += new EventHandler((o, e) => Console.WriteLine("Closing"));
            //        host.Closed += new EventHandler((o, e) => Console.WriteLine("Closed"));
            //        host.UnknownMessageReceived += new EventHandler<UnknownMessageReceivedEventArgs>((o, e) => Console.WriteLine("UnknownMessageReceived: {0}", e.Message));
            //        host.Faulted += new EventHandler((o, e) => Console.WriteLine("Faulted"));

            //        host.Open();

            //        Console.ReadLine();

            //        host.Close();
            //    }
            //}
            //catch (AddressAlreadyInUseException aaiuex)
            //{
            //    Console.WriteLine("{0}", aaiuex.Message);
            //    Console.WriteLine("{0}", aaiuex.StackTrace);
            //}
            //finally
            //{
            //    Console.ReadLine();
            //}

        }
    }
}
