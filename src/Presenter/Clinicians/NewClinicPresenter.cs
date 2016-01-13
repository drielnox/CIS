using CIS.Application.BusinessComponents;
using CIS.Presentation.Model;
using CIS.Presentation.UI.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIS.Presentation.Logic.Presenter
{
    public class NewClinicPresenter
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
    }
}
