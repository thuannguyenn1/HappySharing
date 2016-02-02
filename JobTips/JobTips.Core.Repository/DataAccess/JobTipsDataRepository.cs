using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobTips.Core.Repository.SqlServer;

namespace JobTips.Core.Repository.DataAccess
{
    public class JobTipsDataRepository : SqlServer.Repository
    {
        public override string ConnectionString => System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
    }
}
