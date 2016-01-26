using CIS.Data.DataAccess.UnitOfWork;
using CIS.Presentation.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CIS.Application.BusinessComponents
{
    public class GenreBusinessLogic : IDisposable
    {
        private IUnitOfWork _unitOfWork;

        public GenreBusinessLogic()
        {
            _unitOfWork = new UnitOfWork();
        }

        public IEnumerable<ComboGenreViewModel> GetGenres()
        {
            return _unitOfWork.GenreRepository
                .GetAll()
                .Select(x => new ComboGenreViewModel
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
