using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace CIS.Data.Service.Contract.Repository
{
    [ServiceContract]
    public interface IReadOnlyRepositoryContract<TEntity, TKey>
        where TEntity : class
    {
        [OperationContract]
        TEntity GetById(TKey id);
        [OperationContract]
        IEnumerable<TEntity> GetAll();
    }
}
