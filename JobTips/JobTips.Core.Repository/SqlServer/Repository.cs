using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using JobTips.Core.Repository.DataAccess;

namespace JobTips.Core.Repository.SqlServer
{
    public abstract class Repository<TKey, TEntity> 
        : IRepository<TKey, TEntity> where TEntity : BaseEntity<TKey>
    {
        public abstract string ConnectionString { get; }

        public IUnitOfWork BeginWork()
        {
            SqlConnection sqlConnection = new SqlConnection(this.ConnectionString);
            sqlConnection.Open();
            SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();
            return new SqlUnitOfWork(sqlTransaction);
        }

        public TEntity Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
