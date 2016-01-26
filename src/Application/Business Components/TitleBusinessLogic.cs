using CIS.Application.Entities;
using CIS.Data.DataAccess.UnitOfWork;
using CIS.Presentation.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CIS.Application.BusinessComponents
{
    public class TitleBusinessLogic : IDisposable
    {
        private IUnitOfWork _unitOfWork;

        public TitleBusinessLogic()
        {
            _unitOfWork = new UnitOfWork();
        }

        internal Title GetById(int p)
        {
            return _unitOfWork.TitleRepository.GetById(p);
        }

        public IEnumerable<ComboTitleViewModel> GetTitles()
        {
            return _unitOfWork.TitleRepository
                .GetAll()
                .Select(x => new ComboTitleViewModel
                {
                    Identifier = x.Identifier,
                    Description = x.Description
                });
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
