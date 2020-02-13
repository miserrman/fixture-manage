using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TongManage.Models;

namespace TongManage.Daos
{
    /// <summary>
    /// author: linlianhui
    /// date: 2020/2/3
    /// </summary>
    public class InventoryRecordDao
    {
        /// <summary>
        /// 查询所有库存记录
        /// </summary>
        /// 
        /// <returns>库存记录列表</returns>
        public IList<InventoryRecord> selectAllInventoryRecords(InventoryRecord inventoryRecord)
        {
            return BaseDao.QueryForList<InventoryRecord>("SelectAllInventoryRecords", inventoryRecord);
        }

        /// <summary>
        /// 查询单条库存记录
        /// </summary>
        /// 
        /// <param name="id"></param>
        /// <returns>库存记录</returns>
        public InventoryRecord selectInventoryRecordById(InventoryRecord inventoryRecord)
        {
            return BaseDao.QueryForObject<InventoryRecord>("SelectInventoryRecordById", inventoryRecord);
        }

        /// <summary>
        /// 插入单条库存记录
        /// </summary>
        /// 
        /// <param name="inventoryRecord">库存记录类</param>
        /// <returns>操作状态码</returns>
        public int insertInventoryRecord(InventoryRecord inventoryRecord)
        {
            return BaseDao.Insert<InventoryRecord>("InsertInventoryRecord", inventoryRecord);
        }

        /// <summary>
        /// 更新单条库存记录
        /// </summary>
        /// 
        /// <param name="inventoryRecord">库存记录类</param>
        /// <returns>操作状态码</returns>
        public int updateInventoryRecord(InventoryRecord inventoryRecord)
        {
            return BaseDao.Update<InventoryRecord>("UpdateInventoryRecord", inventoryRecord);
        }

        /// <summary>
        /// 删除单条库存记录
        /// </summary>
        /// 
        /// <param name="id"></param>
        /// <returns>操作状态码</returns>
        public int deleteInventoryRecordById(InventoryRecord inventoryRecord)
        {
            return BaseDao.Delete<InventoryRecord>("DeleteInventoryRecordById", inventoryRecord);
        }
    }
}