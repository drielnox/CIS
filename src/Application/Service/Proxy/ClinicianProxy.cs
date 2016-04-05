using CIS.Application.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIS.Application.Service.Proxy
{
    public class ClinicianProxy : IClinicianContract
    {
        public IEnumerable<Presentation.Model.Common.ComboTitleViewModel> GetTitles()
        {
            throw new NotImplementedException();
        }

        public void UpdateClinic(Presentation.Model.Clinicians.EditClinicViewModel data)
        {
            throw new NotImplementedException();
        }

        public void AddClinic(Presentation.Model.NewClinicPresentationModel model)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
