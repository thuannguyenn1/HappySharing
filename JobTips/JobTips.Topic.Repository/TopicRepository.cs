using JobTips.Topic.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobTips.Core.Repository.DataAccess;

namespace JobTips.Topic.Repository
{
    public class TopicRepository : JobTipsDataRepository, ITopicRepository
    {
        public TopicRepository()
        {
            
        }

        public string Abc(IUnitOfWork unitOfWork)
        {
            return "abc";
        }
    }
}
