using Microsoft.VisualStudio.TestTools.UnitTesting;
using TongManage.Daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TongManage.Models;

namespace TongManage.Daos.Tests
{
    [TestClass()]
    public class InventoryRecordDaoTests
    {
        private static InventoryRecordDao inventoryRecordDao = new InventoryRecordDao();

        [TestMethod()]
        public void selectAllInventoryRecordsTest()
        {
            IList<InventoryRecord> IRList = inventoryRecordDao.selectAllInventoryRecords();
        }

        [TestMethod()]
        public void selectInventoryRecordByIdTest()
        {
            InventoryRecord IR = inventoryRecordDao.selectInventoryRecordById(2);
        }

        [TestMethod()]
        public void insertInventoryRecordTest()
        {
            InventoryRecord inventoryRecord = new InventoryRecord();
            inventoryRecord.Location = "Xiamen";
            inventoryRecordDao.insertInventoryRecord(inventoryRecord);
        }

        [TestMethod()]
        public void updateInventoryRecordTest()
        {
            InventoryRecord inventoryRecord = new InventoryRecord();
            inventoryRecord.Id = 2;
            inventoryRecord.Location = "Fujian";
            inventoryRecordDao.updateInventoryRecord(inventoryRecord);
        }

        [TestMethod()]
        public void deleteInventoryRecordByIdTest()
        {
            inventoryRecordDao.deleteInventoryRecordById(2);
        }
    }
}