using CIS.Application.Entities;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ServiceModel;

namespace CIS.Application.BusinessComponents
{
    public class ClinicianBusinessLogic : IDisposable
    {
#if !DEBUG
        private ChannelFactory<IUnitOfWorkContract> _factory;
#endif

        public ClinicianBusinessLogic()
        {
#if !DEBUG
            _factory = new ChannelFactory<IUnitOfWorkContract>("UnitOfWorkProxyEndPoint");
#endif
        }

        public void AddClinic(Clinic model)
        {
#if !DEBUG
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
#endif
        }

        public void UpdateClinic(Clinic data)
        {
#if !DEBUG
            // TODO: falta implementar.
            var clinic = new Clinic { };

            _factory.ClinicianRepository.Modify(clinic);
#endif
        }

        public IEnumerable<Clinic> GetClinicians()
        {
#if !DEBUG
            return _factory.ClinicianRepository
                .GetAll()
                .Select(x => new ClinicListViewModel
                {
                    Identifier = x.Identifier,
                    FirstName = x.FirstName,
                    LastName = x.LastName
                });
#else
            return null;
#endif
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
#if !DEBUG
            if (disposing)
            {
                _factory.Dispose();
                _factory = null;
            }
#endif
        }
    }
}
