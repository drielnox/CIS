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
        private TitleBusinessLogic _title;

        public ApplicationFaçade()
        {
            _genre = new GenreBusinessLogic();
            _title = new TitleBusinessLogic();
        }

        public GenreBusinessLogic Genre
        {
            get { return _genre; }
        }

        public TitleBusinessLogic Title
        {
            get { return _title; }
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
                if (_genre != null)
                {
                    _genre.Dispose();
                    _genre = null;
                }

                if (_title != null)
                {
                    _title.Dispose();
                    _title = null;
                }
            }
        }
    }
}
