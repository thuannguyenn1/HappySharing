using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobTips.Core.Repository.DataAccess;

namespace JobTips.Topic.BusinessObject
{
    public interface ITopicRepository:IRepository
    {
        string Abc(IUnitOfWork unitOfWork);
    }
}
