using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace CIS.Data.Service.Contract.Repository
{
    [ServiceContract]
    public interface IRepositoryContract<TEntity, TKey> : IReadOnlyRepositoryContract<TEntity, TKey>
        where TEntity : class
    {
        [OperationContract]
        TKey Add(TEntity entity);
        [OperationContract]
        void Modify(TEntity entity);
        [OperationContract]
        void Remove(TEntity entity);
    }
}
