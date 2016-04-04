using CIS.Application.Entities;
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
#else
        private List<Title> _debugTitles = new List<Title>();
#endif

        public TitleBusinessLogic()
        {
#if !DEBUG
            _factory = new ChannelFactory<IUnitOfWorkContract>("UnitOfWorkProxyEndPoint");
#else
            _debugTitles.AddRange(new List<Title>
            {
                Title.MR,
                Title.MRS,
                Title.MISS
            });
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
            return _debugTitles.Single(x => x.Identifier == id);
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
            return _debugTitles;
#endif
        }

        public void AddTitle(Title newTitle)
        {
#if !DEBUG
#else
            _debugTitles.Add(newTitle);
#endif
        }

        public void ModifyTitle(Title modifiedTitle)
        {
#if !DEBUG
#else
            int index = _debugTitles.FindIndex(x => x.Identifier == modifiedTitle.Identifier);
            _debugTitles[index] = modifiedTitle;
#endif
        }

        public void DeleteTitle(Title title)
        {
#if !DEBUG
#else
            _debugTitles.Remove(title);
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
