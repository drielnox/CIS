using CIS.Presentation.Model.Common;
using System;
using System.Collections.Generic;

namespace CIS.Application.BusinessComponents
{
    public class KinRelationshipBusinessLogic : IDisposable
    {
#if !DEBUG
        private IUnitOfWork _unitOfWork;
#endif

        public KinRelationshipBusinessLogic()
        {
#if !DEBUG
            _unitOfWork = new UnitOfWork();
#endif
        }

        public IEnumerable<ComboKinRelationshipViewModel> GetKinRelations()
        {
            throw new System.NotImplementedException();
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
