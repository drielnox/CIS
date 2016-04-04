using CIS.Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace CIS.Application.BusinessComponents
{
    public class GenreBusinessLogic : IDisposable
    {
#if !DEBUG
        private ChannelFactory<IUnitOfWork> _factory;
#endif

        public GenreBusinessLogic()
        {
#if !DEBUG
            _factory = new ChannelFactory<IUnitOfWork>("UnitOfWorkEndPoint");
#endif
        }

        public IEnumerable<Gender> GetGenres()
        {
#if !DEBUG
            try
            {
                using (var proxy = _factory.CreateChannel())
                {
                    return proxy.GenreRepository
                        .GetAll()
                        .Select(x => new ComboGenreViewModel
                        {
                            Identifier = x.Identifier,
                            Description = x.Description
                        });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
                _unitOfWork.Dispose();
                _unitOfWork = null;
            }
#endif
        }
    }
}
