using CIS.Data.DataAccess.UnitOfWork;
using CIS.Presentation.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIS.Application.BusinessComponents
{
    public class GenreBusinessLogic
    {
        private readonly IUnitOfWork _unitOfWork;

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
    }
}
