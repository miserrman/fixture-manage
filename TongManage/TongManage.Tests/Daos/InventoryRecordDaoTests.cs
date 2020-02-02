using Microsoft.VisualStudio.TestTools.UnitTesting;
using TongManage.Daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongManage.Daos.Tests
{
    [TestClass()]
    public class InventoryRecordDaoTests
    {
        private static InventoryRecordDao inventoryRecordDao = new InventoryRecordDao();

        [TestMethod()]
        public void selectAllInventoryRecordsTest()
        {
            inventoryRecordDao.selectAllInventoryRecords();
            //Assert.Fail();
        }

        [TestMethod()]
        public void selectInventoryRecordByIdTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void insertInventoryRecordTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void updateInventoryRecordTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void deleteInventoryRecordByIdTest()
        {
            Assert.Fail();
        }
    }
}