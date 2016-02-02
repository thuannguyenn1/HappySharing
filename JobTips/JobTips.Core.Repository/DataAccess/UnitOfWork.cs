using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Dapper;

namespace JobTips.Core.Repository.DataAccess
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private bool _disposed;

        protected IDbConnection DbConnectionAsync;
        protected IDbTransaction DbTransaction;

        public virtual void CommitChanges()
        {
            this.WithCheckForDisposal(this.DbTransaction.Commit);
        }

        public virtual void Rollback()
        {
            this.WithCheckForDisposal(this.DbTransaction.Rollback);
        }

        #region Dapper's Function

        public int Execute(string sql, dynamic param = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return SqlMapper.Execute(DbConnectionAsync, sql, param, DbTransaction, commandTimeout, commandType);
        }

        public IEnumerable<dynamic> Query(string sql, dynamic param = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null)
        {
            return SqlMapper.Query(DbConnectionAsync, sql, param, DbTransaction, buffered, commandTimeout, commandType);
        }

        public IEnumerable<T> Query<T>(string sql, dynamic param = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null)
        {
            return SqlMapper.Query<T>(DbConnectionAsync, sql, param, DbTransaction, buffered, commandTimeout, commandType);
        }

        public SqlMapper.GridReader QueryMultiple(string sql, dynamic param = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return SqlMapper.QueryMultiple(DbConnectionAsync, sql, param, DbTransaction, commandTimeout, commandType);
        }

        public IEnumerable<TReturn> Query<TFirst, TSecond, TReturn>(string sql, Func<TFirst, TSecond, TReturn> map, dynamic param = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return SqlMapper.Query<TFirst, TSecond, TReturn>(DbConnectionAsync, sql, map, param, DbTransaction, buffered, splitOn, commandTimeout, commandType);
        }

        public IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TReturn>(string sql, Func<TFirst, TSecond, TThird, TReturn> map, dynamic param = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return SqlMapper.Query<TFirst, TSecond, TThird, TReturn>(DbConnectionAsync, sql, map, param, DbTransaction, buffered, splitOn, commandTimeout, commandType);
        }

        public IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TReturn>(string sql, Func<TFirst, TSecond, TThird, TFourth, TReturn> map, dynamic param = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return SqlMapper.Query<TFirst, TSecond, TThird, TFourth, TReturn>(DbConnectionAsync, sql, map, param, DbTransaction, buffered, splitOn, commandTimeout, commandType);
        }

        public IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map, dynamic param = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return SqlMapper.Query<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(DbConnectionAsync, sql, map, param, DbTransaction, buffered, splitOn, commandTimeout, commandType);
        }

        public IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> map, dynamic param = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return SqlMapper.Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(DbConnectionAsync, sql, map, param, DbTransaction, buffered, splitOn, commandTimeout, commandType);
        }

        public IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> map, dynamic param = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return SqlMapper.Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(DbConnectionAsync, sql, map, param, DbTransaction, buffered, splitOn, commandTimeout, commandType);
        }

        #endregion

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (DbConnectionAsync.State == ConnectionState.Open)
                {
                    DbConnectionAsync.Close();
                }
                if (DbTransaction != null)
                {
                    DbTransaction.Dispose();
                    DbTransaction = null;
                }
                if (DbConnectionAsync != null)
                {
                    DbConnectionAsync.Dispose();
                    DbConnectionAsync = null;
                }
            }
        }
        private void WithCheckForDisposal(Action action)
        {
            if (!this._disposed)
                action();
            else
                throw new ObjectDisposedException(this.GetType().Name, "This unit of work has already been disposed.");
        }

        SqlMapper.GridReader IUnitOfWork.QueryMultiple(string sql, dynamic param, int? commandTimeout, CommandType? commandType)
        {
            throw new NotImplementedException();
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }
    }
}
