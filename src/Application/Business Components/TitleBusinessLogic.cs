using CIS.Application.Entities;
using CIS.Data.DataAccess;
using CIS.Presentation.Model.Common;
using System.Collections.Generic;
using System.Linq;

namespace CIS.Application.BusinessComponents
{
    public class TitleBusinessLogic
    {
        internal Title GetById(int p)
        {
            using (var context = new ClinicModel())
            {
                return context.Titles.Single(x => x.Identifier == p);
            }
        }

        public IEnumerable<ComboTitleViewModel> GetTitles()
        {
            using (var context = new ClinicModel())
            {
                return context.Titles
                    .Select(x => new ComboTitleViewModel 
                    { 
                        Identifier = x.Identifier,
                        Description = x.Description
                    })
                    .ToList();
            }
        }
    }
}
