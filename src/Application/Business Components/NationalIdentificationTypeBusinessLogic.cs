using CIS.Data.DataAccess.UnitOfWork;
using CIS.Presentation.Model.Common;
using System;
using System.Collections.Generic;

namespace CIS.Application.BusinessComponents
{
    public class NationalIdentificationTypeBusinessLogic : IDisposable
    {
        private IUnitOfWork _unitOfWork;

        public NationalIdentificationTypeBusinessLogic()
        {
            _unitOfWork = new UnitOfWork();
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
                _unitOfWork.Dispose();
                _unitOfWork = null;
            }
        }
    }
}
