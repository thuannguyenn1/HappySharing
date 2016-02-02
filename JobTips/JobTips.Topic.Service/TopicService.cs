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

        public string Abc()
        {
            using (var unitOfWork = this.TopicRepository.BeginWork())
            {
                return this.TopicRepository.Abc(unitOfWork);
            }
        }
    }
}
