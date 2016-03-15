using CIS.Presentation.Model.Common;
using System;
using System.Collections.Generic;

namespace CIS.Application.BusinessComponents
{
    public class NationalIdentificationTypeBusinessLogic : IDisposable
    {
#if !DEBUG
        private IUnitOfWork _unitOfWork;
#endif

        public NationalIdentificationTypeBusinessLogic()
        {
#if !DEBUG
            _unitOfWork = new UnitOfWork();
#endif
        }

        public IEnumerable<ComboNationalIdTypesViewModel> GetNationalIdTypes()
        {
            throw new NotImplementedException();
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
#if !DEBUG
                _unitOfWork.Dispose();
                _unitOfWork = null;
#endif
            }
        }
    }
}
