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
    public class RepairRecordDao
    {
        /// <summary>
        /// 查询所有维修记录
        /// </summary>
        /// <param name="repairRecord"></param>
        /// <returns>维修记录列表</returns>
        public IList<RepairRecord> selectAllRepairRecords(RepairRecord repairRecord)
        {
            return BaseDao.QueryForList<RepairRecord>("SelectAllRepairRecords", repairRecord);
        }

        /// <summary>
        /// 查询已完成维修记录
        /// </summary>
        /// <param name="repairRecord"></param>
        /// <returns>已完成维修记录列表</returns>
        public IList<RepairRecord> selectAllCompleteRecords(RepairRecord repairRecord)
        {
            return BaseDao.QueryForList<RepairRecord>("SelectAllCompleteRecords", repairRecord);
        }

        /// <summary>
        /// 插入未完成维修记录
        /// </summary>
        /// <param name="repairRecord"></param>
        /// <returns>未完成维修记录列表</returns>
        public IList<RepairRecord> selectAllNotCompleteRecords(RepairRecord repairRecord)
        {
            return BaseDao.QueryForList<RepairRecord>("SelectAllNotCompleteRecords", repairRecord);
        }

        /// <summary>
        /// 查询单条维修记录
        /// </summary>
        /// <param name="repairRecord"></param>
        /// <returns>维修记录</returns>
        public RepairRecord selectRepairRecordById(RepairRecord repairRecord)
        {
            return BaseDao.QueryForObject<RepairRecord>("SelectRepairRecordById", repairRecord);
        }

        /// <summary>
        /// 插入单条维修记录
        /// </summary>
        /// <param name="repairRecord"></param>
        /// <returns>操作状态码</returns>
        public int insertRepairRecord(RepairRecord repairRecord)
        {
            return BaseDao.Insert<RepairRecord>("InsertRepairRecord", repairRecord);
        }

        /// <summary>
        /// 更新单条维修记录
        /// </summary>
        /// <param name="repairRecord"></param>
        /// <returns>操作状态码</returns>
        public int updateRepairRecord(RepairRecord repairRecord)
        {
            return BaseDao.Update<RepairRecord>("UpdateRepairRecord", repairRecord);
        }

        /// <summary>
        /// 删除单条维修记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns>操作状态码</returns>
        public int deleteRepairRecordById(RepairRecord repairRecord)
        {
            return BaseDao.Delete<RepairRecord>("DeleteRepairRecordById", repairRecord);
        }
    }
}