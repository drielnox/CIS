using CIS.Data.DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace CIS.Data.Façade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (ServiceHost host = new ServiceHost(typeof(UnitOfWork)))
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
            catch (Exception ex)
            {
                throw ex;
            }

            //try
            //{
            //    using (DataServiceHost host = new DataServiceHost(typeof(UnitOfWork)))
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
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
        }
    }
}
