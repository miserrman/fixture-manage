using IBatisNet.DataMapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TongManage.Daos
{
    /// <summary>
    /// Dao 层基类
    /// author: linlianhui
    /// date: 2020/2/3
    /// </summary>
    public class BaseDao
    {
        /// <summary>
        /// 插入方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="statementName">sql语句</param>
        /// <param name="t"></param>
        /// <returns>操作状态码</returns>
        public static int Insert<T>(string statementName, T t)
        {
            ISqlMapper iSqlMapper = Mapper.Instance();
            if (iSqlMapper != null)
            {
                try
                {
                    return (int)iSqlMapper.Insert(statementName, t);
                }
                catch(Exception e)
                {
                    return 0;
                }
            }
            return 0;
        }

        /// <summary>
        /// 更新方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="statementName">sql语句</param>
        /// <param name="t"></param>
        /// <returns>操作状态码</returns>
        public static int Update<T>(string statementName, T t)
        {
            ISqlMapper iSqlMapper = Mapper.Instance();
            if (iSqlMapper != null)
            {
                return iSqlMapper.Update(statementName, t);
            }
            return 0;
        }

        /// <summary>
        /// 删除方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="statementName">sql语句</param>
        /// <param name="t"></param>
        /// <returns>操作状态码</returns>
        public static int Delete<T>(string statementName, T t)
        {
            ISqlMapper iSqlMapper = Mapper.Instance();
            if (iSqlMapper != null)
            {
                return iSqlMapper.Update(statementName, t);
            }
            return 0;
        }

        /// <summary>
        /// 查询对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="statementName">sql语句</param>
        /// <param name="t"></param>
        /// <returns>查询结果</returns>
        public static T QueryForObject<T>(string statementName, T t) where T : class
        {
            ISqlMapper iSqlMapper = Mapper.Instance();
            if (iSqlMapper != null)
            {
                return iSqlMapper.QueryForObject<T>(statementName, t);
            }
            return null;
        }

        /// <summary>
        /// 查询列表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="statementName">sql语句</param>
        /// <param name="t"></param>
        /// <returns>查询结果</returns>
        public static IList<T> QueryForList<T>(string statementName, T t)
        {
            ISqlMapper iSqlMapper = Mapper.Instance();
            if (iSqlMapper != null)
            {
                return iSqlMapper.QueryForList<T>(statementName, t);
            }
            return null;
        }
    }
}