using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JobTips.Core.Repository.DataAccess
{
    public interface IRepository<TKey, TEntity> 
        : IBaseRepository<TKey, TEntity> where TEntity 
        : BaseEntity<TKey>
    {
        IUnitOfWork BeginWork();
    }
}
