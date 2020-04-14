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
            RepairRecord repairRecord = JSONHelper.JSONToObject<RepairRecord>(body);
            repairRecord.Id = id;
            RepairRecord result = repairService.UpdateRecord(repairRecord);
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
            string token = TokenHelper.GetTokenJson(HttpContext.Request.Headers["Authorization"]);//利用这个进行数据按部门进行隔离
            TokenInfo tokenInfo = JSONHelper.JSONToObject<TokenInfo>(token);
            int WorkcellId = tokenInfo.workCell;
            RepairRecord repairRecord = new RepairRecord();
            repairRecord.WorkcellId = WorkcellId;
            List<RepairRecord> result = repairService.GetCompleteRecord(repairRecord);
            return JSONHelper.ObjectToJSON(ResponseUtil.Ok(result));
        }

        /// <summary>
        /// 得到所有维修未完成的记录
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string GetNotCompleteRecord()
        {
            string token = TokenHelper.GetTokenJson(HttpContext.Request.Headers["Authorization"]);//利用这个进行数据按部门进行隔离
            TokenInfo tokenInfo = JSONHelper.JSONToObject<TokenInfo>(token);
            int WorkcellId = tokenInfo.workCell;
            RepairRecord repairRecord = new RepairRecord();
            repairRecord.WorkcellId = WorkcellId;
            List<RepairRecord> result = repairService.GetNotCompleteRecord(repairRecord);
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
            string token = TokenHelper.GetTokenJson(HttpContext.Request.Headers["Authorization"]);//利用这个进行数据按部门进行隔离
            TokenInfo tokenInfo = JSONHelper.JSONToObject<TokenInfo>(token);
            int WorkcellId = tokenInfo.workCell;
            RepairRecord repairRecord = new RepairRecord();
            repairRecord.Id = id;
            repairRecord.WorkcellId = WorkcellId;
            RepairRecord result = repairService.GetRecord(repairRecord);
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
            string token = TokenHelper.GetTokenJson(HttpContext.Request.Headers["Authorization"]);//利用这个进行数据按部门进行隔离
            TokenInfo tokenInfo = JSONHelper.JSONToObject<TokenInfo>(token);
            int WorkcellId = tokenInfo.workCell;
            RepairRecord repairRecord = new RepairRecord();
            repairRecord.WorkcellId = WorkcellId;
            List<RepairRecord> result = repairService.GetRepairChart(repairRecord);
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
            RepairRecord repairRecord = new RepairRecord();
            repairRecord.Id = id;
            int result = repairService.DeleteRecordById(repairRecord);
            if(result==1)
                return JSONHelper.ObjectToJSON(ResponseUtil.Ok());
            else
                return JSONHelper.ObjectToJSON(ResponseUtil.Fail());
        }
    }
}
