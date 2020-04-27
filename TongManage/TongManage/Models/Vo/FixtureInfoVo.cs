using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TongManage.Models.Vo
{
    public class FixtureInfoVo
    {
        private TongsEntity tongsEntity;
        private TongsDefinition tongsDefinition;
        private List<InventoryRecord> inventoryRecords;
        private List<RepairRecord> repairRecords;

        public TongsEntity TongsEntity { get => tongsEntity; set => tongsEntity = value; }
        public TongsDefinition TongsDefinition { get => tongsDefinition; set => tongsDefinition = value; }
        public List<RepairRecord> RepairRecords { get => repairRecords; set => repairRecords = value; }
        public List<InventoryRecord> InventoryRecords { get => inventoryRecords; set => inventoryRecords = value; }
    }
}