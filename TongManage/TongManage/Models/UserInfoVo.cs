using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TongManage.Models
{
    public class UserInfoVo
    {
        private string name;
        private string workcellName;

        public string Name { get => name; set => name = value; }
        public string WorkcellName { get => workcellName; set => workcellName = value; }
    }
}