using CIS.Application.Entities;
using CIS.Presentation.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace CIS.Application.BusinessComponents
{
    public class TitleBusinessLogic : IDisposable
    {
#if !DEBUG
        private ChannelFactory<IUnitOfWorkContract> _factory;
#endif

        public TitleBusinessLogic()
        {
#if !DEBUG
            _factory = new ChannelFactory<IUnitOfWorkContract>("UnitOfWorkProxyEndPoint");
#endif
        }

        internal Title GetById(int id)
        {
#if !DEBUG
            try
            {
                using (var proxy = _factory.CreateChannel())
                {
                    return proxy.TitleRepository.GetById(id);
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

        public IEnumerable<Title> GetTitles()
        {
#if !DEBUG
            try
            {
                using (var proxy = _factory.CreateChannel())
                {
                    return proxy.TitleRepository
                            .GetAll()
                            .Select(x => new ComboTitleViewModel
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
            return new List<Title> 
            { 
                Title.MR,
                Title.MRS,
                Title.MISS
            };
#endif
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
#if !DEBUG
                if (_factory != null)
                {
                    _factory = null;
                }
#endif
            }
        }
    }
}
