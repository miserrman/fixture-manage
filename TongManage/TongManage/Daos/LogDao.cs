using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TongManage.Models;

namespace TongManage.Daos
{
    /// <summary>
    /// author: rentianhe
    /// date: 2020/2/3
    /// </summary>
    public class LogDao
    {
        /// <summary>
        /// 查看所有日志
        /// </summary>
        /// <param name="log"></param>
        /// <returns></returns>
        public IList<Log> selectAllLogs(Log log)
        {
            return BaseDao.QueryForList<Log>("SelectAllLogs", log);
        }

        /// <summary>
        /// 查询单条日志记录
        /// </summary>
        /// <param name="log"></param>
        /// <returns>日志记录</returns>
        public Log selectLogById(Log log)
        {
            return BaseDao.QueryForObject<Log>("SelectLogById", log);
        }

        /// <summary>
        /// 插入一条日志
        /// </summary>
        /// <param name="log"></param>
        /// <returns>操作状态码</returns>
        public int insertLog(Log log)
        {
            return BaseDao.Insert<Log>("InsertLog", log);
        }

        /// <summary>
        /// 更新日志信息
        /// </summary>
        /// <param name="log"></param>
        /// <returns>操作状态码</returns>
        public int updateLog(Log log)
        {
            return BaseDao.Update<Log>("UpdateInventoryRecord", log);
        }

        /// <summary>
        /// 删除单条日志记录
        /// </summary>
        /// <param name="log"></param>
        /// <returns>操作状态码</returns>
        public int deleteLogById(Log log)
        {
            return BaseDao.Delete<Log>("DeleteLogById", log);
        }
    }
}