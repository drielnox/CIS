using CIS.Presentation.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CIS.Application.BusinessComponents
{
    public class MaritalStatusBusinessLogic : IDisposable
    {
#if !DEBUG
        private IUnitOfWork _unitOfWork;
#endif

        public MaritalStatusBusinessLogic()
        {
#if !DEBUG
            _unitOfWork = new UnitOfWork();
#endif
        }

        public IEnumerable<ComboMaritalStatusViewModel> GetMaritalStatuses()
        {
#if !DEBUG
            return _unitOfWork.MaritalStatusRepository
                .GetAll()
                .Select(x => new ComboMaritalStatusViewModel
                {
                    Identifier = x.Identifier,
                    Description = x.Description
                });
#else
            return null;
#endif
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
#if !DEBUG
            if (disposing)
            {
                _unitOfWork.Dispose();
                _unitOfWork = null;
            }
#endif
        }
    }
}
