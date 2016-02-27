using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTips.Topic.BusinessObject
{
    public class TopicPagingObject
    {
        public IList<Topic> Topics { get; set; }

        public int NumberOfTopic { get; set; }
    }
}
