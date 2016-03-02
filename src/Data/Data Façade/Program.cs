using CIS.Data.DataFaçade.UnitOfWork;
using System;
using System.ServiceModel;

namespace CIS.Data.DataFaçade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (ServiceHost host = new ServiceHost(typeof(UnitOfWorkService)))
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
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
    }
}
