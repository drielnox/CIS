using CIS.Presentation.Model;

namespace CIS.Presentation.UI.Contracts
{
    public interface INewClinicView
    {
        void LoadTitles();
        int GetSelectedTitle();
        NewClinicPresentationModel GetClinicianData();
    }
}
