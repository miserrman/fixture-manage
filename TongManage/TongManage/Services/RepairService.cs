using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TongManage.Daos;
using TongManage.Models;

namespace TongManage.Services
{
    /// <summary>
    /// author: ZhouXing
    /// date: 2020/2/5
    /// </summary>
    public class RepairService
    {
        static RepairRecordDao repairRecordDao =new RepairRecordDao();
        /// <summary>
        /// 创建一条维修记录
        /// </summary>
        /// <param name="record">工夹具类</param>
        /// <returns>RepairRecord</returns>
        public RepairRecord CreateRecord(RepairRecord record)
        {
            record.GmtCreate = DateTime.Now.ToLocalTime();
            record.GmtModified = DateTime.Now.ToLocalTime();
            repairRecordDao.insertRepairRecord(record);
            return record;
        }

        /// <summary>
        /// 修改一条维修记录
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="record">id</param>
        /// <returns>RepairRecord</returns>
        public RepairRecord UpdateRecord(RepairRecord record)
        {
            RepairRecord repairRecord = repairRecordDao.selectRepairRecordById(record);
            record.GmtCreate = repairRecord.GmtCreate;
            record.GmtModified= DateTime.Now.ToLocalTime();
            int result=repairRecordDao.updateRepairRecord(record);
            if (result == 0)
                return null;
            else
                return record;
        }

        /// <summary>
        /// 得到所有维修完成的记录
        /// </summary>
        /// <returns></returns>
        public List<RepairRecord> GetCompleteRecord(RepairRecord record)
        {
            return repairRecordDao.selectAllCompleteRecords(record).ToList();
        }

        /// <summary>
        /// 得到所有维修未完成的记录
        /// </summary>
        /// <returns></returns>
        public List<RepairRecord> GetNotCompleteRecord(RepairRecord record)
        {
            return repairRecordDao.selectAllNotCompleteRecords(record).ToList();
        }

        /// <summary>
        /// 搜索维修记录
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        public RepairRecord GetRecord(RepairRecord record)
        {
            return repairRecordDao.selectRepairRecordById(record);
        }

        /// <summary>
        /// 获取工夹具维修报表
        /// </summary>
        /// <returns></returns>
        public List<RepairRecord> GetRepairChart(RepairRecord record)
        {
            return repairRecordDao.selectAllRepairRecords(record).ToList();
        }

        /// <summary>
        /// 删除记录
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        public int DeleteRecordById(RepairRecord record)
        {
            RepairRecord repairRecord = repairRecordDao.selectRepairRecordById(record);
            repairRecord.GmtModified = DateTime.Now.ToLocalTime();
            repairRecordDao.updateRepairRecord(repairRecord);
            int temp= repairRecordDao.deleteRepairRecordById(record);
            if(temp==1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}