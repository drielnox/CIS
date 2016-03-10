using CIS.Application.Entities;
using CIS.Presentation.Model;
using CIS.Presentation.Model.Clinicians;
using CIS.Presentation.Model.Common;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ServiceModel;
using CIS.Data.Service.Contract.UnitOfWork;

namespace CIS.Application.BusinessComponents
{
    public class ClinicianBusinessLogic : IDisposable
    {
        private ChannelFactory<IUnitOfWorkContract> _factory;

        public ClinicianBusinessLogic()
        {
            _factory = new ChannelFactory<IUnitOfWorkContract>("UnitOfWorkProxyEndPoint");
        }

        public void AddClinic(NewClinicPresentationModel model)
        {
            var title = _factory.TitleRepository.GetById(model.Title);

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

            _factory.ClinicianRepository.Add(clinic);
            _factory.Save();
        }

        public void UpdateClinic(EditClinicViewModel data)
        {
            // TODO: falta implementar.
            var clinic = new Clinic { };

            _factory.ClinicianRepository.Modify(clinic);
        }

        public IEnumerable<ClinicListViewModel> GetClinicians()
        {
            return _factory.ClinicianRepository
                .GetAll()
                .Select(x => new ClinicListViewModel
                {
                    Identifier = x.Identifier,
                    FirstName = x.FirstName,
                    LastName = x.LastName
                });
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
                _factory.Dispose();
                _factory = null;
            }
        }
    }
}
