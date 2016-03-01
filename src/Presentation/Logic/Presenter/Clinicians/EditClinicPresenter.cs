using CIS.Application.BusinessComponents;
using CIS.Presentation.Model.Clinicians;
using CIS.Presentation.UI.Contracts.Clinicians;
using System;

namespace CIS.Presentation.Logic.Presenter.Clinicians
{
    public class EditClinicPresenter : IDisposable
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

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _titleLogic.Dispose();
                _titleLogic = null;
                _clinicianLogic.Dispose();
                _clinicianLogic = null;
            }
        }
    }
}
