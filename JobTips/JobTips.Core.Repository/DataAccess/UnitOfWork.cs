using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace JobTips.Core.Repository.DataAccess
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private bool _disposed;

        public IDbTransaction DbTransaction { get; set; }
        public IDbConnection DbConnectionAsync { get; set; }

        public virtual void CommitChanges()
        {
            this.WithCheckForDisposal(this.DbTransaction.Commit);
        }

        public virtual void Rollback()
        {
            this.WithCheckForDisposal(this.DbTransaction.Rollback);
        }

        #region Dapper's Function

        /// <inheritdoc/>
        public virtual IEnumerable<dynamic> Query(string sql, dynamic parameters = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null)
        {
            return SqlMapper.Query(this.DbConnectionAsync, sql, parameters, this.DbTransaction, buffered, commandTimeout, commandType);
        }

        /// <inheritdoc/>
        public virtual IEnumerable<T> Query<T>(string sql, dynamic parameters = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null)
        {
            return SqlMapper.Query<T>(this.DbConnectionAsync, sql, parameters, this.DbTransaction, buffered, commandTimeout, commandType);
        }

        /// <inheritdoc/>
        public virtual IEnumerable<TReturn> Query<TFirst, TSecond, TReturn>(string sql, Func<TFirst, TSecond, TReturn> map, dynamic parameters = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return SqlMapper.Query<TFirst, TSecond, TReturn>(this.DbConnectionAsync, sql, map, parameters, this.DbTransaction, buffered, splitOn, commandTimeout, commandType);
        }

        /// <inheritdoc/>
        public virtual IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TReturn>(string sql, Func<TFirst, TSecond, TThird, TReturn> map, dynamic parameters = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return SqlMapper.Query<TFirst, TSecond, TThird, TReturn>(this.DbConnectionAsync, sql, map, parameters, this.DbTransaction, buffered, splitOn, commandTimeout, commandType);
        }

        /// <inheritdoc/>
        public virtual IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TReturn>(string sql, Func<TFirst, TSecond, TThird, TFourth, TReturn> map, dynamic parameters = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return SqlMapper.Query<TFirst, TSecond, TThird, TFourth, TReturn>(this.DbConnectionAsync, sql, map, parameters, this.DbTransaction, buffered, splitOn, commandTimeout, commandType);
        }

        /// <inheritdoc/>
        public virtual IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map, dynamic parameters = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return SqlMapper.Query<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(this.DbConnectionAsync, sql, map, parameters, this.DbTransaction, buffered, splitOn, commandTimeout, commandType);
        }

        /// <inheritdoc/>
        public virtual IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> map, dynamic parameters = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return SqlMapper.Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(this.DbConnectionAsync, sql, map, parameters, this.DbTransaction, buffered, splitOn, commandTimeout, commandType);
        }

        /// <inheritdoc/>
        public virtual IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> map, dynamic parameters = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return SqlMapper.Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(this.DbConnectionAsync, sql, map, parameters, this.DbTransaction, buffered, splitOn, commandTimeout, commandType);
        }

        /// <inheritdoc/>
        public virtual Task<IEnumerable<T>> QueryAsAsync<T>(string sql, dynamic parameters = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return SqlMapper.QueryAsync<T>(this.DbConnectionAsync, sql, parameters, this.DbTransaction, commandTimeout, commandType);
        }

        /// <inheritdoc/>
        public virtual Task<IEnumerable<TReturn>> QueryAsAsync<TFirst, TSecond, TReturn>(string sql, Func<TFirst, TSecond, TReturn> map, dynamic parameters = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return SqlMapper.QueryAsync<TFirst, TSecond, TReturn>(this.DbConnectionAsync, sql, map, parameters, this.DbTransaction, buffered, splitOn, commandTimeout, commandType);
        }

        /// <inheritdoc/>
        public virtual Task<IEnumerable<TReturn>> QueryAsAsync<TFirst, TSecond, TThird, TReturn>(string sql, Func<TFirst, TSecond, TThird, TReturn> map, dynamic parameters = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return SqlMapper.QueryAsync<TFirst, TSecond, TThird, TReturn>(this.DbConnectionAsync, sql, map, parameters, this.DbTransaction, buffered, splitOn, commandTimeout, commandType);
        }

        /// <inheritdoc/>
        public virtual Task<IEnumerable<TReturn>> QueryAsAsync<TFirst, TSecond, TThird, TFourth, TReturn>(string sql, Func<TFirst, TSecond, TThird, TFourth, TReturn> map, dynamic parameters = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return SqlMapper.QueryAsync<TFirst, TSecond, TThird, TFourth, TReturn>(this.DbConnectionAsync, sql, map, parameters, this.DbTransaction, buffered, splitOn, commandTimeout, commandType);
        }

        /// <inheritdoc/>
        public virtual Task<IEnumerable<TReturn>> QueryAsAsync<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map, dynamic parameters = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return SqlMapper.QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(this.DbConnectionAsync, sql, map, parameters, this.DbTransaction, buffered, splitOn, commandTimeout, commandType);
        }

        /// <inheritdoc/>
        public virtual Task<IEnumerable<TReturn>> QueryAsAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> map, dynamic parameters = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return SqlMapper.QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(this.DbConnectionAsync, sql, map, parameters, this.DbTransaction, buffered, splitOn, commandTimeout, commandType);
        }

        /// <inheritdoc/>
        public virtual Task<IEnumerable<TReturn>> QueryAsAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> map, dynamic parameters = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return SqlMapper.QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(this.DbConnectionAsync, sql, map, parameters, this.DbTransaction, buffered, splitOn, commandTimeout, commandType);
        }

        /// <inheritdoc/>
        public virtual IGridReader QueryMultiple(string sql, dynamic parameters = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            SqlMapper.GridReader dapperGridReader = SqlMapper.QueryMultiple(this.DbConnectionAsync, sql, parameters, this.DbTransaction, commandTimeout, commandType);
            return new GridReader(dapperGridReader);
        }

        /// <inheritdoc/>
        public virtual int Execute(string sql, dynamic parameters, int? commandTimeOut = null, CommandType? commandType = null)
        {
            return SqlMapper.Execute(this.DbConnectionAsync, sql, parameters, this.DbTransaction, commandTimeOut, commandType);
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

        ~UnitOfWork()
        {
            Dispose(false);
        }
    }
}
