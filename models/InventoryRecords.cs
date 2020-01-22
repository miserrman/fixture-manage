﻿using System;

/**
 * author: zhouxing
 * date: 2020/01/22
 */
namespace Models
{
    public class InventoryRecords
    {
        private int id;
        private DateTime logOn;
        private int logBy;
        private int handledBy;
        private bool inOrOut;
        private int productionLine;
        private int tongId;
        private string location;
        private DateTime gmtCreate;
        private DateTime gmtModified;
        private bool isDeleted;

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
    }
}