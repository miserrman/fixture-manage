using System;

/**
 * author: linlianhui
 * date: 2020/01/22
 */
namespace TongManage.Models
{
    public class TongsDefinition
    {
        private int id;
        private int workcellId;
        private int familyId;
        private string code;
        private string name;
        private string model;
        private string partNo;
        private string userdFor;
        private int upl;
        private int ownerId;
        private string remark;
        private int pmPeriod;
        private DateTime recOn;
        private int recBy;
        private DateTime editOn;
        private int editBy;
        private DateTime gmtCreate;
        private DateTime gmtModified;
        private bool isDeleted;

        public TongsDefinition()
        {
            this.id = -1;
            this.workcellId = -1;
            this.familyId = -1;
            this.upl = -1;
            this.ownerId = -1;
            this.pmPeriod = -1;
            this.recBy = -1;
            this.editBy = -1;
    }

        public int Id { get => id; set => id = value; }
        public int WorkcellId { get => workcellId; set => workcellId = value; }
        public int FamilyId { get => familyId; set => familyId = value; }
        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Model { get => model; set => model = value; }
        public string PartNo { get => partNo; set => partNo = value; }
        public string UserdFor { get => userdFor; set => userdFor = value; }
        public int Upl { get => upl; set => upl = value; }
        public int OwnerId { get => ownerId; set => ownerId = value; }
        public string Remark { get => remark; set => remark = value; }
        public int PmPeriod { get => pmPeriod; set => pmPeriod = value; }
        public DateTime RecOn { get => recOn; set => recOn = value; }
        public int RecBy { get => recBy; set => recBy = value; }
        public DateTime EditOn { get => editOn; set => editOn = value; }
        public int EditBy { get => editBy; set => editBy = value; }
        public DateTime GmtCreate { get => gmtCreate; set => gmtCreate = value; }
        public DateTime GmtModified { get => gmtModified; set => gmtModified = value; }
        public bool IsDeleted { get => isDeleted; set => isDeleted = value; }
    }
}