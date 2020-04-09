using System;

/**
 * author: zhouxing
 * date: 2020/01/22
 */
 //test
namespace TongManage.Models
{
    public class InventoryRecord
    {
        private int id;
        private DateTime logOn;
        private int logBy;
        private int handledBy;
        private bool inOrOut;
        private int productionLine;
        private int tongId;
        private string location;
        private int workcellId;
        private DateTime gmtCreate;
        private DateTime gmtModified;
        private bool isDeleted;

        public InventoryRecord()
        {
            this.id = -1;
            this.logBy = -1;
            this.handledBy = -1;
            this.productionLine = -1;
            this.tongId = -1;
            this.workcellId = -1;
        }

        public int Id { get => id; set => id = value; }
        public DateTime LogOn { get => logOn; set => logOn = value; }
        public int LogBy { get => logBy; set => logBy = value; }
        public int HandledBy { get => handledBy; set => handledBy = value; }
        public bool InOrOut { get => inOrOut; set => inOrOut = value; }
        public int ProductionLine { get => productionLine; set => productionLine = value; }
        public int TongId { get => tongId; set => tongId = value; }
        public string Location { get => location; set => location = value; }
        public DateTime GmtCreate { get => gmtCreate; set => gmtCreate = value; }
        public DateTime GmtModified { get => gmtModified; set => gmtModified = value; }
        public bool IsDeleted { get => isDeleted; set => isDeleted = value; }
        public int WorkcellId { get => workcellId; set => workcellId = value; }
    }
}