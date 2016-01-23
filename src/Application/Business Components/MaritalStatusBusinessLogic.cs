using CIS.Data.DataAccess.UnitOfWork;
using CIS.Presentation.Model.Common;
using System.Collections.Generic;
using System.Linq;

namespace CIS.Application.BusinessComponents
{
    public class MaritalStatusBusinessLogic
    {
        private readonly IUnitOfWork _unitOfWork;

        public MaritalStatusBusinessLogic()
        {
            _unitOfWork = new UnitOfWork();
        }

        public IEnumerable<ComboMaritalStatusViewModel> GetMaritalStatuses()
        {
            return _unitOfWork.MaritalStatusRepository
                .GetAll()
                .Select(x => new ComboMaritalStatusViewModel 
                { 
                    Identifier = x.Identifier,
                    Description = x.Description
                });
        }
    }
}
