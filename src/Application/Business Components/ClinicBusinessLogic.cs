using CIS.Application.Entities;
using CIS.Data.DataAccess;
using CIS.Presentation.Models;
using System;

namespace CIS.Application.BusinessComponents
{
    public class ClinicBusinessLogic
    {
        private readonly TitleBusinessLogic _titleBl;

        public ClinicBusinessLogic()
        {
            _titleBl = new TitleBusinessLogic();
        }

        public void AddClinic(NewClinicPresentationModel model)
        {
            var title = _titleBl.GetById(model.Title);

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

            using (var context = new ClinicModel())
            {
                context.Clinicians.Add(clinic);
                context.SaveChanges();
            }
        }
    }
}
