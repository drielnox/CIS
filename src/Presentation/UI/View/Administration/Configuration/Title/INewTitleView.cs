using CIS.Presentation.Model.Administration.Title;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIS.Presentation.UI.Contracts.Administration.Configuration.Title
{
    public interface INewTitleView
    {
        string GetAbbreviation();

        string GetDescription();

        void SetFormTag(TitleViewModel model);
    }
}
