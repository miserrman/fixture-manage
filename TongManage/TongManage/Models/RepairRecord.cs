using System;

/**
 * author: linlianhui
 * date: 2020/01/22
 */
namespace Models
{
    public class RepairRecord
    {
        private int id;
        private DateTime repairOn;
        private int tongId;
        private string description;
        private DateTime repairOverOn;
        private DateTime gmtCreate;
        private DateTime gmtModified;
        private bool isDeleted;

        public int Id { get => id; set => id = value; }
        public DateTime RepairOn { get => repairOn; set => repairOn = value; }
        public int TongId { get => tongId; set => tongId = value; }
        public string Description { get => description; set => description = value; }
        public DateTime RepairOverOn { get => repairOverOn; set => repairOverOn = value; }
        public DateTime GmtCreate { get => gmtCreate; set => gmtCreate = value; }
        public DateTime GmtModified { get => gmtModified; set => gmtModified = value; }
        public bool IsDeleted { get => isDeleted; set => isDeleted = value; }
    }
}