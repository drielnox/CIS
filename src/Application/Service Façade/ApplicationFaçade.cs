using CIS.Application.BusinessComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace CIS.Application.Façade
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    internal class ApplicationFaçade : IApplicationFaçade
    {
        private GenreBusinessLogic _genre;

        public ApplicationFaçade()
        {
            _genre = new GenreBusinessLogic();
        }

        public GenreBusinessLogic Genre
        {
            get { return _genre; }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                //if (_context != null)
                //{
                //    _context.Dispose();
                //    _context = null;
                //}
            }
        }
    }
}
