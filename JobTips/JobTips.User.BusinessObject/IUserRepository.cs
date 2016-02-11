using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobTips.Core.Repository.DataAccess;

namespace JobTips.User.BusinessObject
{
    public interface IUserRepository:IRepository
    {
        string  Abc(IUnitOfWork unitOfWork);
    }
}
