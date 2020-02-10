using System;

/**
 * author: zhouxing
 * date: 2020/01/22
 */
namespace TongManage.Models
{
    public class TongsEntity
    {
        private int id;
        private string code;
        private int seqId;
        private string billNo;
        private DateTime regDate;
        private int userdCount;
        private string location;
        private string picUrl;
        private DateTime productionDate;
        private DateTime documentDate;
        private int operatorId;
        private bool isScrapped;
        private bool status;
        private int repairCounts;
        private DateTime lastRepairOn;
        private int expextedLife;
        private int workcellId;
        private DateTime gmtCreate;
        private DateTime gmtModified;
        private bool isDeleted;

        public int Id { get => id; set => id = value; }
        public string Code { get => code; set => code = value; }
        public int SeqId { get => seqId; set => seqId = value; }
        public string BillNo { get => billNo; set => billNo = value; }
        public DateTime RegDate { get => regDate; set => regDate = value; }
        public int UserdCount { get => userdCount; set => userdCount = value; }
        public string Location { get => location; set => location = value; }
        public string PicUrl { get => picUrl; set => picUrl = value; }
        public DateTime ProductionDate { get => productionDate; set => productionDate = value; }
        public DateTime DocumentDate { get => documentDate; set => documentDate = value; }
        public int OperatorId { get => operatorId; set => operatorId = value; }
        public bool IsScrapped { get => isScrapped; set => isScrapped = value; }
        public bool Status { get => status; set => status = value; }
        public int RepairCounts { get => repairCounts; set => repairCounts = value; }
        public DateTime LastRepairOn { get => lastRepairOn; set => lastRepairOn = value; }
        public int ExpextedLife { get => expextedLife; set => expextedLife = value; }
        public DateTime GmtCreate { get => gmtCreate; set => gmtCreate = value; }
        public DateTime GmtModified { get => gmtModified; set => gmtModified = value; }
        public bool IsDeleted { get => isDeleted; set => isDeleted = value; }
        public int WorkcellId { get => workcellId; set => workcellId = value; }
    }
}