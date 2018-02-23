
using CIS.Presentation.Model.Clinicians;
using CIS.Presentation.Model.Common;
using CIS.Transversal.SharedKernel.Patterns.MVP;
using System.Collections.Generic;

namespace CIS.Presentation.UI.Contracts.Administration
{
    public interface IViewCliniciansView : IView
    {
        void SetGridInitialSettings();
        void LoadClinicians(IEnumerable<ClinicListViewModel> clinicians);
        ClinicListViewModel GetSelectedClinic();
        void ShowEditClinicForm(EditClinicViewModel clinic);
    }
}
