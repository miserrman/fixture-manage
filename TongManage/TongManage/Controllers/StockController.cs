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
    public class StockController : Controller
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
        /// 创建一条维修记录
        /// </summary>
        /// <param name="body">工夹具类</param>
        /// <returns></returns>
        [HttpPost]
        public string CreateRepairRecord(string body)
        {
            return null;
        }

        /// <summary>
        /// 修改一条维修记录
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        [HttpPut]
        public string UpdateRepairRecord(int id)
        {
            return null;
        }

        /// <summary>
        /// 得到所有维修完成的记录
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string GetCompleteRepairRecord()
        {
            return null;
        }

        /// <summary>
        /// 得到所有维修未完成的记录
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string GetNotCompleteRepairRecord()
        {
            return null;
        }

        /// <summary>
        /// 搜索维修记录
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        [HttpGet]
        public string GetRepairRecord(int id)
        {
            return null;
        }

        /// <summary>
        /// 获取工夹具维修报表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string GetRepairChart()
        {
            return null;
        }

        /// <summary>
        /// 获取工夹具维修报表
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        [HttpDelete]
        public string DeleteRepairRecordById(int id)
        {
            return null;
        }
    }
}
