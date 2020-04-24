using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TongManage.Models
{
    public class TongsEntityVo
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
        private int status;
        private int repairCounts;
        private DateTime lastRepairOn;
        private int expextedLife;
        private int workcellId;
        private DateTime gmtCreate;
        private DateTime gmtModified;
        private bool isDeleted;
        private int familyId;
        private string name;
        private string model;
        private string partNo;
        private string userdFor;
        private int upl;
        private int ownerId;
        private string remark;
        private int pmPeriod;
        public TongsEntityVo()
        {
            this.Id = -1;
            this.SeqId = -1;
            this.UserdCount = -1;
            this.OperatorId = -1;
            this.RepairCounts = -1;
            this.ExpextedLife = -1;
            this.WorkcellId = -1;
            this.Status = -1;
            this.FamilyId = -1;
            this.Upl = -1;
            this.OwnerId = -1;
            this.PmPeriod = -1;
        }

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
        public int Status { get => status; set => status = value; }
        public int RepairCounts { get => repairCounts; set => repairCounts = value; }
        public DateTime LastRepairOn { get => lastRepairOn; set => lastRepairOn = value; }
        public int ExpextedLife { get => expextedLife; set => expextedLife = value; }
        public int WorkcellId { get => workcellId; set => workcellId = value; }
        public DateTime GmtCreate { get => gmtCreate; set => gmtCreate = value; }
        public DateTime GmtModified { get => gmtModified; set => gmtModified = value; }
        public bool IsDeleted { get => isDeleted; set => isDeleted = value; }
        public int FamilyId { get => familyId; set => familyId = value; }
        public string Name { get => name; set => name = value; }
        public string Model { get => model; set => model = value; }
        public string PartNo { get => partNo; set => partNo = value; }
        public string UserdFor { get => userdFor; set => userdFor = value; }
        public int Upl { get => upl; set => upl = value; }
        public int OwnerId { get => ownerId; set => ownerId = value; }
        public string Remark { get => remark; set => remark = value; }
        public int PmPeriod { get => pmPeriod; set => pmPeriod = value; }
    }
}