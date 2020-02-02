using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TongManage.Models;

namespace TongManage.Daos
{
    public class InventoryRecordDao
    {
        public IList<InventoryRecord> selectAllInventoryRecords()
        {
            return BaseDao.QueryForList<InventoryRecord>("SelectAllInventoryRecords");
        }

        public InventoryRecord selectInventoryRecordById(int id)
        {
            return BaseDao.SelectById<InventoryRecord>("SelectInventoryRecordById", id);
        }

        public int insertInventoryRecord(InventoryRecord inventoryRecord)
        {
            return BaseDao.Insert<InventoryRecord>("InsertInventoryRecord", inventoryRecord);
        }

        public int updateInventoryRecord(InventoryRecord inventoryRecord)
        {
            return BaseDao.Update<InventoryRecord>("UpdateInventoryRecord", inventoryRecord);
        }

        public int deleteInventoryRecordById(int id)
        {
            return BaseDao.Delete("DeleteInventoryRecordById", id);
        }
    }
}