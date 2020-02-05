using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TongManage.Daos;
using TongManage.Models;

namespace TongManage.Services
{
    public class StockService
    {
        private static InventoryRecordDao inventoryRecordDao  = new InventoryRecordDao();

        /// <summary>
        /// 创建一条进出库记录
        /// </summary>
        /// 
        /// <param name="inventoryRecord">进出库记录类</param>
        /// <returns>操作状态码</returns>
        public int CreateFixtureRecord(InventoryRecord inventoryRecord)
        {
            return inventoryRecordDao.insertInventoryRecord(inventoryRecord);
        }

        /// <summary>
        /// 通过ID查找对应的进出库记录
        /// </summary>
        /// 
        /// <param name="id"></param>
        /// <returns></returns>
        public InventoryRecord GetRecordDetailById(int id)
        {
            return inventoryRecordDao.selectInventoryRecordById(id);
        }

        /// <summary>
        /// 通过ID删除对应的进出库记录
        /// </summary>
        /// 
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteRecordById(int id)
        {
            return inventoryRecordDao.deleteInventoryRecordById(id);
        }
    }
}