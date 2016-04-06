using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace CIS.Application.Service.Host
{
    internal class DerivedServiceHost : ServiceHost
    {
        public DerivedServiceHost(Type type, params Uri[] baseAddresses)
             : base(type, baseAddresses)
        {
        }

        protected override void OnAbort()
        {
            Console.WriteLine(string.Format("({0}) Abort", ToString()));
            base.OnAbort();
        }

        protected override IAsyncResult OnBeginClose(TimeSpan timeout, AsyncCallback callback, object state)
        {
            Console.WriteLine("OnBeginClose");
            return base.OnBeginClose(timeout, callback, state);
        }

        protected override IAsyncResult OnBeginOpen(TimeSpan timeout, AsyncCallback callback, object state)
        {
            Console.WriteLine("OnBeginOpen");
            return base.OnBeginOpen(timeout, callback, state);
        }

        protected override void OnClose(TimeSpan timeout)
        {
            Console.WriteLine("Close");
            base.OnClose(timeout);
        }

        protected override void OnClosed()
        {
            Console.WriteLine("Closed");
            base.OnClosed();
        }

        protected override void OnClosing()
        {
            Console.WriteLine("Closing");
            base.OnClosing();
        }

        protected override void OnEndClose(IAsyncResult result)
        {
            Console.WriteLine("OnEndClose");
            base.OnEndClose(result);
        }

        protected override void OnEndOpen(IAsyncResult result)
        {
            Console.WriteLine("OnEndOpen");
            base.OnEndOpen(result);
        }

        protected override void OnFaulted()
        {
            Console.WriteLine("Faulted");
            base.OnFaulted();
        }

        protected override void OnOpen(TimeSpan timeout)
        {
            string msg = string.Format("({0}) Open", ToString());
            Console.WriteLine(msg);
            base.OnOpen(timeout);
        }

        protected override void OnOpened()
        {
            string msg = string.Format("({0}) Opened", ToString());
            Console.WriteLine(msg);
            base.OnOpened();
        }

        protected override void OnOpening()
        {
            string msg = string.Format("({0}) Opening", ToString());
            Console.WriteLine(msg);
            base.OnOpening();
        }
    }
}
