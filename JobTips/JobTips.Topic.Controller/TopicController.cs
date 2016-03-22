using System.Collections.Generic;
using JobTips.Topic.BusinessObject;
using System.Web.Http;


namespace JobTips.Topic.Controller
{
    public class TopicController : ApiController
    {
        public ITopicService TopicService;

        public TopicController(ITopicService topicService)
        {
            this.TopicService = topicService;
        }

        public TopicPagingObject GetTopicByIndex(int index, int numberPerPage, bool isActive)
        {
            return this.TopicService.GetTopicsByIndex(index, numberPerPage, isActive);
        }


        public BusinessObject.Topic GetTopicById(int topicId)
        {
            return this.TopicService.GetTopicById(topicId);
        }

        [HttpPost]
        public int SaveTopics(IList<BusinessObject.Topic> topics)
        {
            return this.TopicService.SaveTopic(topics);
        }

        [HttpPost]
        public int DeleteTopics(IList<int> topicIds)
        {
            return this.TopicService.DeleteTopic(topicIds);
        }

    }
}
