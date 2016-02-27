using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTips.Topic.BusinessObject
{
    public class Topic
    {
        public int Id { get; set; }

        public string TopicTitle { get; set; }

        public int Views { get; set; }

        public float Rating { get; set; }

        public int UserId { get; set; }

        public bool IsActive { get; set; }

        public string TopicBody { get; set; }

        public string TopicFooter { get; set; }

        public DateTime Inserted { get; set; }

        public DateTime Updated { get; set; }
    }
}
