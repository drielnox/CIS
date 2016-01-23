using CIS.Application.Entities;
using CIS.Data.DataAccess;
using CIS.Data.DataAccess.UnitOfWork;
using CIS.Presentation.Model;
using CIS.Presentation.Model.Common;
using CIS.Presentation.Model.Patients;
using System;
using System.Collections.Generic;

namespace CIS.Application.BusinessComponents
{
    public class ClinicianBusinessLogic
    {
        private readonly IUnitOfWork _unitOfWork;
        
        public ClinicianBusinessLogic()
        {
            _unitOfWork = new UnitOfWork();
        }

        public void AddClinic(NewClinicPresentationModel model)
        {
            var title = _unitOfWork.TitleRepository.GetById(model.Title);

            var clinic = new Clinic
            {
                Address = model.Address,
                CreatedAt = DateTime.Now,
                Department = model.Department,
                Email = model.Email,
                FirstName = model.FirstName,
                InternalCode = model.InternalCode,
                LastName = model.LastName,
                Specialty = model.Specialty,
                Telephone = model.Telephone,
                Title = title
            };

            _unitOfWork.ClinicianRepository.Add(clinic);
            _unitOfWork.Save();
        }

        public void UpdateClinic(Presentation.Model.Clinicians.EditClinicViewModel data)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClinicListViewModel> GetClinicians()
        {
            throw new NotImplementedException();
        }
    }
}
