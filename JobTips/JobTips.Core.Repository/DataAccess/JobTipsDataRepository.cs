using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobTips.Core.Repository.SqlServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Memory;

namespace JobTips.Core.Repository.DataAccess
{
    public class JobTipsDataRepository<TKey, TEntity> : Repository<TKey, TEntity> where TEntity : BaseEntity<TKey>
    {
        public override string ConnectionString
        {
            get
            {
                var builder = new ConfigurationBuilder();
                builder.Add(new MemoryConfigurationProvider());
                var config = builder.Build();
                return config["Data:DefaultConnection:ConnectionString"];
            }
        }
    }
}
