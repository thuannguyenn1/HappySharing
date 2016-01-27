using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JobTips.Core.Repository.DataAccess
{
    public abstract class BaseEntity<TKey>
    {
        public TKey Id { get; set; }
        public DateTime Inserted { get; set; }
        public DateTime Updated { get; set; }
    }
}
