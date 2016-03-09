using CIS.Data.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace CIS.Data.Service.Contract.Repository
{
    [ServiceContract]
    public interface IUserRepositoryContract : IUserRepository
    {
    }
}
