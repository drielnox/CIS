
using CIS.Presentation.Model.Clinicians;
using CIS.Presentation.Model.Common;
using System.Collections.Generic;

namespace CIS.Presentation.UI.Contracts.Administration
{
    public interface IViewCliniciansView
    {
        void LoadClinicians(IEnumerable<ClinicListViewModel> clinicians);

        EditClinicViewModel GetClinic();

        void ShowEditClinicForm(EditClinicViewModel clinic);
    }
}
