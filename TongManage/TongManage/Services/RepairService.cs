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
        public RepairRecord UpdateRecord(int id,RepairRecord record)
        {
            RepairRecord repairRecord = repairRecordDao.selectRepairRecordById(id);
            record.GmtCreate = repairRecord.GmtCreate;
            record.GmtModified= DateTime.Now.ToLocalTime();
            record.Id = id;
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
        public List<RepairRecord> GetCompleteRecord()
        {
            return repairRecordDao.selectAllCompleteRecords().ToList();
        }

        /// <summary>
        /// 得到所有维修未完成的记录
        /// </summary>
        /// <returns></returns>
        public List<RepairRecord> GetNotCompleteRecord()
        {
            return repairRecordDao.selectAllNotCompleteRecords().ToList();
        }

        /// <summary>
        /// 搜索维修记录
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        public RepairRecord GetRecord(int id)
        {
            return repairRecordDao.selectRepairRecordById(id);
        }

        /// <summary>
        /// 获取工夹具维修报表
        /// </summary>
        /// <returns></returns>
        public List<RepairRecord> GetRepairChart()
        {
            return repairRecordDao.selectAllRepairRecords().ToList();
        }

        /// <summary>
        /// 删除记录
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        public int DeleteRecordById(int id)
        {
            int temp= repairRecordDao.deleteRepairRecordById(id);
            if(temp==1)
            {
                RepairRecord repairRecord = repairRecordDao.selectRepairRecordById(id);
                repairRecord.GmtModified= DateTime.Now.ToLocalTime();
                repairRecordDao.updateRepairRecord(repairRecord);
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}