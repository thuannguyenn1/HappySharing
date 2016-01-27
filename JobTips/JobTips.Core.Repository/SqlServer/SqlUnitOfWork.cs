using System.Data.SqlClient;
using JobTips.Core.Repository.DataAccess;

namespace JobTips.Core.Repository.SqlServer
{
    public class SqlUnitOfWork : UnitOfWork
    {
        public SqlUnitOfWork(SqlTransaction transaction)
            : base()
        {
            this.DbTransaction = transaction;
            this.DbConnectionAsync = transaction.Connection;
        }

        ~SqlUnitOfWork()
        {
            this.Dispose(false);
        }

        public new SqlConnection Connection
        {
            get { return (SqlConnection)base.DbConnectionAsync; }
            set { base.DbConnectionAsync = value; }
        }

        /// <summary>
        /// Gets or sets the SQL-Server transaction.
        /// </summary>
        public new SqlTransaction Transaction
        {
            get { return (SqlTransaction)base.DbTransaction; }
            set { base.DbTransaction = value; }
        }
    }
}
