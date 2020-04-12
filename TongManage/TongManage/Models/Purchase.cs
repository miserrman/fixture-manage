using System;

/**
 * author: linlianhui
 * date: 2020/01/22
 */
namespace TongManage.Models
{
    public class Purchase
    {
        private int id;
        private String billNo;
        private int operatorId;
        private DateTime logOn;
        private int tongId;
        private int workcellId;
        private DateTime gmtCreate;
        private DateTime gmtModified;
        private bool isDeleted;

        public Purchase()
        {
            this.id = -1;
            this.operatorId = -1;
            this.tongId = -1;
            this.workcellId = -1;
        }

        public int Id { get => id; set => id = value; }
        public string BillNo { get => billNo; set => billNo = value; }
        public int OperatorId { get => operatorId; set => operatorId = value; }
        public DateTime LogOn { get => logOn; set => logOn = value; }
        public int TongId { get => tongId; set => tongId = value; }
        public DateTime GmtCreate { get => gmtCreate; set => gmtCreate = value; }
        public DateTime GmtModified { get => gmtModified; set => gmtModified = value; }
        public bool IsDeleted { get => isDeleted; set => isDeleted = value; }
        public int WorkcellId { get => workcellId; set => workcellId = value; }
    }
}