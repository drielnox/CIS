using CIS.Application.BusinessComponents;
using CIS.Presentation.Model;
using CIS.Presentation.Model.Clinicians;
using CIS.Presentation.UI.Contracts.Clinicians;
using System.Collections.Generic;

namespace CIS.Presentation.Logic.Presenter.Clinicians
{
    public class EditClinicPresenter
    {
        private IEditClinicView _view;
        private TitleBusinessLogic _titleLogic;
        private ClinicianBusinessLogic _clinicianLogic;

        public EditClinicPresenter(IEditClinicView view)
        {
            _view = view;
            _titleLogic = new TitleBusinessLogic();
            _clinicianLogic = new ClinicianBusinessLogic();
        }

        public void LoadTitles()
        {
            var titles = _titleLogic.GetTitles();
            _view.LoadTitles(titles);
        }

        public void SetFormData(EditClinicViewModel viewModel)
        {
            _view.LoadFormData(viewModel);
        }

        public void Save()
        {
            EditClinicViewModel data = _view.GetFormData();
            _clinicianLogic.UpdateClinic(data);
        }
    }
}
