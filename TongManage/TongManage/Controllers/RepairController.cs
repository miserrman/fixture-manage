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
using TongManage.Utils;
using TongManage.Services;

namespace TongManage.Controllers
{
    public class RepairController : Controller
    {
        static RepairService repairService = new RepairService();
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
        public string CreateRecord(string body)
        {
            string token = HttpContext.Request.Headers["Authorization"];//利用这个进行数据按部门进行隔离
            //待补充
            RepairRecord repairRecord = JSONHelper.JSONToObject<RepairRecord>(body);
            RepairRecord result = repairService.CreateRecord(repairRecord);
            return JSONHelper.ObjectToJSON(ResponseUtil.Ok(result));
        }

        /// <summary>
        /// 修改一条维修记录
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        [HttpPut]
        public string UpdateRecord(int id,string body)
        {
            string token=HttpContext.Request.Headers["Authorization"];
            RepairRecord repairRecord = JSONHelper.JSONToObject<RepairRecord>(body);
            RepairRecord result = repairService.UpdateRecord(id,repairRecord);
            if(result!=null)
            return JSONHelper.ObjectToJSON(ResponseUtil.Ok(result));
            else
                return JSONHelper.ObjectToJSON(ResponseUtil.Fail());
        }

        /// <summary>
        /// 得到所有维修完成的记录
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string GetCompleteRecord()
        {
            List<RepairRecord> result = repairService.GetCompleteRecord();
            return JSONHelper.ObjectToJSON(ResponseUtil.Ok(result));
        }

        /// <summary>
        /// 得到所有维修未完成的记录
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string GetNotCompleteRecord()
        {
            List<RepairRecord> result = repairService.GetNotCompleteRecord();
            return JSONHelper.ObjectToJSON(ResponseUtil.Ok(result));
        }

        /// <summary>
        /// 搜索维修记录
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        [HttpGet]
        public string GetRecord(int id)
        {
            RepairRecord result = repairService.GetRecord(id);
            if (result != null)
            {
                return JSONHelper.ObjectToJSON(ResponseUtil.Ok(result));
            }
            else
                return JSONHelper.ObjectToJSON(ResponseUtil.Fail());
        }

        /// <summary>
        /// 获取工夹具维修报表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string GetRepairChart()
        {
            List<RepairRecord> result = repairService.GetRepairChart();
            return JSONHelper.ObjectToJSON(ResponseUtil.Ok(result));
        }

        /// <summary>
        /// 删除记录
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        [HttpDelete]
        public string DeleteRecordById(int id)
        {
            int result = repairService.DeleteRecordById(id);
            if(id==1)
                return JSONHelper.ObjectToJSON(ResponseUtil.Ok());
            else
                return JSONHelper.ObjectToJSON(ResponseUtil.Fail());
        }
    }
}
