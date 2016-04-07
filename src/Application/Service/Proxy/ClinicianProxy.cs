using CIS.Application.BusinessComponents;
using CIS.Application.Entities;
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
        private TitleBusinessLogic _titleBl;

        public ClinicianProxy()
        {
            _clinicianBl = new ClinicianBusinessLogic();
            _titleBl = new TitleBusinessLogic();
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

        public ClinicViewModel GetClinician(int id)
        {
            var clinic = _clinicianBl.GetClinician(id);
            return new ClinicViewModel()
            {
                InternalCode = clinic.InternalCode,
                Identifier = clinic.Identifier,
                LastName = clinic.LastName,
                Title = clinic.Title,
                FirstName = clinic.FirstName,
                Specialty = clinic.Specialty,
                Department = clinic.Department,
                Address = clinic.Address,
                Telephone = clinic.Telephone.ToString(),
                Email = clinic.Email
            };
        }

        public IEnumerable<ComboTitleViewModel> GetTitles()
        {
            var titles = _titleBl.GetTitles();
            return titles.Select(x => new ComboTitleViewModel()
            {
                Identifier = x.Identifier,
                Description = x.Description
            });
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
