using System;

/**
 * author: zhouxing
 * date: 2020/01/22
 */
namespace TongManage.Models
{
    public class Scrap
    {
        private int id;
        private int operatorId;
        private DateTime logOn;
        private int tongId;
        private string description;
        private DateTime gmtCreate;
        private DateTime gmtModified;
        private bool isDeleted;

        public int Id { get => id; set => id = value; }
        public int OperatorId { get => operatorId; set => operatorId = value; }
        public DateTime LogOn { get => logOn; set => logOn = value; }
        public int TongId { get => tongId; set => tongId = value; }
        public string Description { get => description; set => description = value; }
        public DateTime GmtCreate { get => gmtCreate; set => gmtCreate = value; }
        public DateTime GmtModified { get => gmtModified; set => gmtModified = value; }
        public bool IsDeleted { get => isDeleted; set => isDeleted = value; }
    }
}