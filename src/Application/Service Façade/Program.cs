using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace CIS.Application.Façade
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(ApplicationFaçade)))
            {
                host.Open();

                Console.WriteLine("Server open...");

                Console.ReadLine();

                host.Close();
            }
        }
    }
}
