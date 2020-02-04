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
        public IList<Log> selectAllLogs()
        {
            return BaseDao.QueryForList<Log>("SelectAllLogs");
        }

        public Log selectLogById(int id)
        {
            return BaseDao.SelectById<Log>("SelectLogById", id);
        }

        public int insertLog(Log log)
        {
            return BaseDao.Insert<Log>("InsertLog", log);
        }

        public int updateLog(Log log)
        {
            return BaseDao.Update<Log>("UpdateInventoryRecord", log);
        }

        public int deleteLogById(int id)
        {
            return BaseDao.Delete("DeleteLogById", id);
        }
    }
}