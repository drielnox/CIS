using CIS.Application.Entities;
using CIS.Data.Service.Contract.UnitOfWork;
using CIS.Presentation.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace CIS.Application.BusinessComponents
{
    public class TitleBusinessLogic : IDisposable
    {
        private ChannelFactory<IUnitOfWorkContract> _factory;

        public TitleBusinessLogic()
        {
            _factory = new ChannelFactory<IUnitOfWorkContract>("UnitOfWorkProxyEndPoint");
        }

        internal Title GetById(int id)
        {
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
        }

        public IEnumerable<ComboTitleViewModel> GetTitles()
        {
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
                if (_factory != null)
                {
                    _factory = null;
                }
            }
        }
    }
}
