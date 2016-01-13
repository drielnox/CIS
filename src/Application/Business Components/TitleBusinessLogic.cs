using CIS.Application.Entities;
using CIS.Data.DataAccess;
using CIS.Presentation.Model;
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
            throw new System.NotImplementedException();
        }
    }
}
