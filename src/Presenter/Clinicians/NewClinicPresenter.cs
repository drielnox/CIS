using CIS.Application.BusinessComponents;
using CIS.Presentation.Model;
using CIS.Presentation.UI.Contracts;
using System;
using System.Linq;

namespace CIS.Presentation.Logic.Presenter
{
    public class NewClinicPresenter : IDisposable
    {
        private INewClinicView _view;
        private ClinicianBusinessLogic _clinicBl;

        public NewClinicPresenter(INewClinicView view)
        {
            _view = view;
            _clinicBl = new ClinicianBusinessLogic();
        }

        public void Save(NewClinicPresentationModel model)
        {
            _clinicBl.AddClinic(model);
        }

        public bool ValidateClinicNumber(string p)
        {
            return string.IsNullOrWhiteSpace(p) || p.Any(c => !char.IsNumber(c));
        }

        public bool ValidateLastName(string p)
        {
            return string.IsNullOrWhiteSpace(p) || p.Any(c => !char.IsLetter(c));
        }

        public NewClinicPresentationModel GetClinicianData()
        {
            return _view.GetClinicianData();
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
                _clinicBl.Dispose();
                _clinicBl = null;
            }
        }
    }
}
