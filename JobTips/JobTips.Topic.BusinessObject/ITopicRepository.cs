using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobTips.Core.Repository.DataAccess;

namespace JobTips.Topic.BusinessObject
{
    public interface ITopicRepository:IRepository
    {
        TopicPagingObject GetTopicsByIndex(int index, int numberPerPage, bool isActive, IUnitOfWork unitOfWork);

        Topic GetTopicById(int topicId, IUnitOfWork unitOfWork);

        int SaveTopic(IList<Topic> topicInfo, IUnitOfWork unitOfWork);

        int DeleteTopic(IList<int> topicId, IUnitOfWork unitOfWork);
    }
}
