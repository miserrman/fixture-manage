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
        private string code;
        private int seqId;
        private int defId;
        private int workcellId;
        private int status;
        private DateTime gmtCreate;
        private DateTime gmtModified;
        private bool isDeleted;

        public Purchase()
        {
            this.id = -1;
            this.operatorId = -1;
            this.SeqId = -1;
            this.DefId = -1;
            this.workcellId = -1;
            this.status = -1;
        }

        public int Id { get => id; set => id = value; }
        public string BillNo { get => billNo; set => billNo = value; }
        public int OperatorId { get => operatorId; set => operatorId = value; }
        public DateTime LogOn { get => logOn; set => logOn = value; }
        public DateTime GmtCreate { get => gmtCreate; set => gmtCreate = value; }
        public DateTime GmtModified { get => gmtModified; set => gmtModified = value; }
        public bool IsDeleted { get => isDeleted; set => isDeleted = value; }
        public int WorkcellId { get => workcellId; set => workcellId = value; }
        public int Status { get => status; set => status = value; }
        public string Code { get => code; set => code = value; }
        public int SeqId { get => seqId; set => seqId = value; }
        public int DefId { get => defId; set => defId = value; }
    }
}