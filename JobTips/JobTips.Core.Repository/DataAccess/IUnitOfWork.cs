using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace JobTips.Core.Repository.DataAccess
{
    public interface IUnitOfWork : IBaseUnitOfWork
    {
        int Execute(string sql, dynamic param = null, int? commandTimeout = null, CommandType? commandType = null);

        IEnumerable<dynamic> Query(string sql, dynamic param = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null);

        IEnumerable<T> Query<T>(string sql, object parameters, dynamic param = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null);

        SqlMapper.GridReader QueryMultiple(string sql, dynamic param = null, int? commandTimeout = null, CommandType? commandType = null);

        IEnumerable<TReturn> Query<TFirst, TSecond, TReturn>(string sql, Func<TFirst, TSecond, TReturn> map, dynamic param = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null);

        IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TReturn>(string sql, Func<TFirst, TSecond, TThird, TReturn> map, dynamic param = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null);

        IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TReturn>(string sql, Func<TFirst, TSecond, TThird, TFourth, TReturn> map, dynamic param = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null);


        IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map, dynamic param = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null);


        IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> map, dynamic param = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null);

        IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> map, dynamic param = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null);
    }
}
