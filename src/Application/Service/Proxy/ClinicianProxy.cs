using CIS.Application.BusinessComponents;
using CIS.Application.Service.Contract;
using CIS.Presentation.Model;
using CIS.Presentation.Model.Clinicians;
using CIS.Presentation.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIS.Application.Service.Proxy
{
    public class ClinicianProxy : IClinicianContract
    {
        private ClinicianBusinessLogic _clinicianBl;

        public ClinicianProxy()
        {
            _clinicianBl = new ClinicianBusinessLogic();
        }

        public IEnumerable<ClinicListViewModel> GetClinicians()
        {
            var clinics = _clinicianBl.GetClinicians();
            return clinics.Select(x => new ClinicListViewModel()
            {
                Identifier = x.Identifier,
                FirstName = x.FirstName,
                LastName = x.LastName
            });
        }

        public IEnumerable<ComboTitleViewModel> GetTitles()
        {
            throw new NotImplementedException();
        }

        public void UpdateClinic(EditClinicViewModel data)
        {
            throw new NotImplementedException();
        }

        public void AddClinic(NewClinicPresentationModel model)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
