using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace JobTips.Core.Repository.DataAccess
{
    public interface IBaseUnitOfWork : IDisposable
    {
        void CommitChanges();
        void Rollback();
    }
}
