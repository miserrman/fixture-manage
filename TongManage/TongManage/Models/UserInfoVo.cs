using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TongManage.Models
{
    public class UserInfoVo
    {
        private string name;
        private int workcellId;
        public UserInfoVo()
        {
            this.workcellId = -1;
        }
        public string Name { get => name; set => name = value; }
        public int WorkcellId { get => workcellId; set => workcellId = value; }
    }
}