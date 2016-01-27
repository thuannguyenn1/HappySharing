using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JobTips.Core.Repository.DataAccess
{
    public interface IBaseRepository<TKey, TEntity> 
        where TEntity : BaseEntity<TKey>
    {
        TEntity Insert(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity Delete(TEntity entity);
    }
}
