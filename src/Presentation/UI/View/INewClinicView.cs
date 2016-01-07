using CIS.Presentation.Models;

namespace CIS.Presentation.UI.Contracts
{
    public interface INewClinicView
    {
        void LoadTitles();
        int GetSelectedTitle();
        NewClinicPresentationModel GetClinicianData();
    }
}
