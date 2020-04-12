using System;

/**
 * author: linlianhui
 * date: 2020/01/22
 */
namespace TongManage.Models
{
    public class Workcell
    {
        private int id;
        private string name;
        private DateTime gmtCreate;
        private DateTime gmtModified;
        private bool isDeleted;

        public Workcell()
        {
            this.id = -1;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime GmtCreate { get => gmtCreate; set => gmtCreate = value; }
        public DateTime GmtModified { get => gmtModified; set => gmtModified = value; }
        public bool IsDeleted { get => isDeleted; set => isDeleted = value; }
    }
}