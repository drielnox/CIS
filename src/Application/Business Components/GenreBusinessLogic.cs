using CIS.Data.DataAccess.UnitOfWork;
using CIS.Presentation.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace CIS.Application.BusinessComponents
{
    public class GenreBusinessLogic : IDisposable
    {
        //private IUnitOfWork _unitOfWork;
        private ChannelFactory<IUnitOfWork> _factory;

        public GenreBusinessLogic()
        {
            _factory = CreateFactory();

            //_unitOfWork = new UnitOfWork();
        }

        public IEnumerable<ComboGenreViewModel> GetGenres()
        {
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

            

            //return _unitOfWork.GenreRepository
            //    .GetAll()
            //    .Select(x => new ComboGenreViewModel
            //    {
            //        Identifier = x.Identifier,
            //        Description = x.Description
            //    });
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
                //_unitOfWork.Dispose();
                //_unitOfWork = null;
            }
        }

        private ChannelFactory<IUnitOfWork> CreateFactory()
        {
            try
            {
                return new ChannelFactory<IUnitOfWork>("UnitOfWorkEndPoint");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
