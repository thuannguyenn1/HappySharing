using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTips.Topic.BusinessObject
{
    public interface ITopicService
    {
        TopicPagingObject GetTopicsByIndex(int index, int numberPerPage, bool isActive);

        Topic GetTopicById(int topicId);

        int SaveTopic(IList<Topic> topicInfo);

        int DeleteTopic(IList<int> topicId);
    }
}
