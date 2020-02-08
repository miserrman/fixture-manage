using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TongManage.Daos;
using TongManage.Models;

namespace TongManage.Services
{
    /// <summary>
    /// Stock Service类
    /// author: linlianhui
    /// date: 2020/2/5
    /// </summary>
    public class StockService
    {
        private static InventoryRecordDao inventoryRecordDao  = new InventoryRecordDao();

        /// <summary>
        /// 创建一条进出库记录
        /// </summary>
        /// 
        /// <param name="inventoryRecord">进出库记录类</param>
        /// <returns>刚创建的对象</returns>
        public InventoryRecord createFixtureRecord(InventoryRecord inventoryRecord)
        {
            inventoryRecord.GmtCreate = DateTime.Now.ToLocalTime();
            inventoryRecord.GmtModified = DateTime.Now.ToLocalTime();
            inventoryRecordDao.insertInventoryRecord(inventoryRecord);
            return inventoryRecord;
        }

        /// <summary>
        /// 通过ID删除对应的进出库记录
        /// </summary>
        /// 
        /// <param name="id"></param>
        /// <returns>操作状态码</returns>
        public int deleteRecordById(int id)
        {
            int status = inventoryRecordDao.deleteInventoryRecordById(id);
            if (1 == status)
            {
                InventoryRecord inventoryRecord = inventoryRecordDao.selectInventoryRecordById(id);
                inventoryRecord.GmtModified = DateTime.Now.ToLocalTime();
                inventoryRecordDao.updateInventoryRecord(inventoryRecord);
            }
            return status;
        }

        /// <summary>
        /// 通过ID查找对应的工夹具出入库记录
        /// </summary>
        /// 
        /// <param name="id"></param>
        /// <returns>单条进出库记录</returns>
        public InventoryRecord getRecordDetailById(int id)
        {
            return inventoryRecordDao.selectInventoryRecordById(id);
        }

        /// <summary>
        /// 获取工夹具出入库报表
        /// </summary>
        /// 
        /// <returns>工夹具出入库列表</returns>
        public List<InventoryRecord> getInventoryRecordList()
        {
            return inventoryRecordDao.selectAllInventoryRecords().ToList<InventoryRecord>();
        }
    }
}