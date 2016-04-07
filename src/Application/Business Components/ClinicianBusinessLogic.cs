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
#else
        private List<Clinic> _clinics;
#endif

        public ClinicianBusinessLogic()
        {
#if !DEBUG
            _factory = new ChannelFactory<IUnitOfWorkContract>("UnitOfWorkProxyEndPoint");
#else
            _clinics = new List<Clinic>
            {
                new Clinic() { Identifier = 1, FirstName = "Goerge", LastName = "Marxit"},
                new Clinic() { Identifier = 2, FirstName = "Wells", LastName = "Furbit"},
                new Clinic() { Identifier = 3, FirstName = "Pete", LastName = "Macarr"},
            };
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
#else
            _clinics.Add(model);
#endif
        }

        public void UpdateClinic(Clinic data)
        {
#if !DEBUG
            // TODO: falta implementar.
            var clinic = new Clinic { };

            _factory.ClinicianRepository.Modify(clinic);
#else
            int index = _clinics.FindIndex(x => x.Identifier == data.Identifier);
            _clinics[index] = data;
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
            return _clinics;
#endif
        }

        public Clinic GetClinician(int id)
        {
#if !DEBUG
#else
            return _clinics.Single(x => x.Identifier == id);
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
