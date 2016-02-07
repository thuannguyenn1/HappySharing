using JobTips.Topic.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using JobTips.Topic.Service;

namespace JobTips.Topic.Controller
{
    public class TopicController : ApiController
    {
        public ITopicService TopicService;

        public TopicController(ITopicService topicService)
        {
            this.TopicService = topicService;
        }

        [HttpGet]
        public string Abc()
        {
            return TopicService.Abc();
        }
    }
}
