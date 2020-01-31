using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Http;
using TongManage.Models;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace TongManage.Controllers
{
    public class FixtureController : Controller
    {
        /*
        // GET: Fixture/Details/5
        public string Details(int id, string role)
        {
            Role r = JsonConvert.DeserializeObject<Role>(role);
            string res = JsonConvert.SerializeObject(r);
            return res;
        }
        */

        /// <summary>
        /// 创建工具夹类别
        /// </summary>
        /// <param name="body">工具夹类别类</param>
        /// <returns></returns>
        [HttpPost]
        public string CreateDef(string body)
        {
            return null;
        }

        /// <summary>
        /// 修改工具夹类别信息
        /// </summary>
        /// <param name="id">路径id</param>
        /// <param name="body">工具夹类别类</param>
        /// <returns></returns>
        [HttpPut]
        public string UpdateDef(int id, string body)
        {
            return null;
        }

        /// <summary>
        /// 得到工具夹类别
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public string GetDefById(int id)
        {
            return null;
        }

        /// <summary>
        /// 获取工具夹报表文件
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string GetDefChart()
        {
            return null;
        }
      
    }
}
