
using CIS.Presentation.Model.Clinicians;
using CIS.Presentation.Model.Common;
using System.Collections.Generic;

namespace CIS.Presentation.UI.Contracts.Administration
{
    public interface IViewCliniciansView
    {
        void SetGridInitialSettings();
        void LoadClinicians(IEnumerable<ClinicListViewModel> clinicians);
        ClinicListViewModel GetSelectedClinic();
        void ShowEditClinicForm(EditClinicViewModel clinic);
    }
}
