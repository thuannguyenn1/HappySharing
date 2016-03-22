using JobTips.Topic.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTips.Topic.Service
{
    public class TopicService : ITopicService
    {
        public ITopicRepository TopicRepository;
        public TopicService(ITopicRepository topicRepository)
        {
            this.TopicRepository = topicRepository;
        }

        public TopicPagingObject GetTopicsByIndex(int index, int numberPerPage, bool isActive)
        {
            using (var unitOfWork = this.TopicRepository.BeginWork())
            {
                var result = this.TopicRepository.GetTopicsByIndex(index, numberPerPage, isActive, unitOfWork);
                return result;
            }
        }

        public BusinessObject.Topic GetTopicById(int topicId)
        {
            using (var unitOfWork = this.TopicRepository.BeginWork())
            {
                var result = this.TopicRepository.GetTopicById(topicId, unitOfWork);
                return result;
            }
        }

        public int SaveTopic(IList<BusinessObject.Topic> topicInfo)
        {
            using (var unitOfWork = this.TopicRepository.BeginWork())
            {
                var result = this.TopicRepository.SaveTopic(topicInfo, unitOfWork);
                unitOfWork.CommitChanges();
                return result;
            }
        }

        public int DeleteTopic(IList<int> topicId)
        {
            using (var unitOfWork = this.TopicRepository.BeginWork())
            {
                var result = this.TopicRepository.DeleteTopic(topicId, unitOfWork);
                unitOfWork.CommitChanges();
                return result;
            }
        }
    }
}
