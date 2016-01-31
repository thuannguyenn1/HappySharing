using JobTips.Topic.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTips.Topic.Controller
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class TopicController
    {
        private readonly ITopicService _topicService;

        public TopicController(ITopicService topicService)
        {
            this._topicService = topicService;
        }
    }
}
