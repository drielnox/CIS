using CIS.Data.DataAccess.Repository;
using System;

namespace CIS.Data.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ClinicModel _context = new ClinicModel();
        
        private ITitleRepository _titleRepository;
        private IGenderRepository _genderRepository;
        private IMaritalStatusRepository _maritalStatusRepository;
        private IClinicianRepository _clinicianRepository;

        public ITitleRepository TitleRepository
        {
            get 
            { 
                return _titleRepository ??
                    (_titleRepository = new TitleRepository(_context));
            }
        }

        public IGenderRepository GenreRepository
        {
            get 
            {
                return _genderRepository ??
                    (_genderRepository = new GenderRepository(_context));
            }
        }

        public IMaritalStatusRepository MaritalStatusRepository
        {
            get 
            { 
                return _maritalStatusRepository ??
                    (_maritalStatusRepository = new MaritalStatusRepository(_context)); 
            }
        }

        public IClinicianRepository ClinicianRepository
        {
            get 
            { 
                return _clinicianRepository ??
                    (_clinicianRepository = new ClinicianRepository(_context));
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }
    }
}
