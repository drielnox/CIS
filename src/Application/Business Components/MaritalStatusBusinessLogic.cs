using CIS.Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CIS.Application.BusinessComponents
{
    public class MaritalStatusBusinessLogic : IDisposable
    {
#if !DEBUG
        private IUnitOfWork _unitOfWork;
#else
        List<MaritalStatus> _maritalStatuses;
#endif

        public MaritalStatusBusinessLogic()
        {
#if !DEBUG
            _unitOfWork = new UnitOfWork();
#else
            _maritalStatuses = new List<MaritalStatus>
            {
                MaritalStatus.SINGLE,
                MaritalStatus.MARRIED,
                MaritalStatus.DIVORCED,
                MaritalStatus.WIDOWED,
            };
#endif
        }

        public IEnumerable<MaritalStatus> GetMaritalStatuses()
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
            return _maritalStatuses;
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
