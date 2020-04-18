using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Http;
using TongManage.Models;
using System.Data.SqlClient;
using TongManage.Services;
using TongManage.Utils;

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

        private static StockService stockService = new StockService();
        private static UserService userService = new UserService();

        /// <summary>
        /// 创建一条入库记录
        /// </summary>
        /// <param name="body">工夹具类</param>
        /// <returns></returns>
        [HttpPost]
        public string CreateFixtureInRecord(string body)
        {
            string token = TokenHelper.GetTokenJson(HttpContext.Request.Headers["Authorization"]);
            TokenInfo tokenInfo = JSONHelper.JSONToObject<TokenInfo>(token);
            User temp = new User();
            temp.Name = tokenInfo.UserName;
            User user = userService.getUserByName(temp);

            InventoryRecord inventoryRecord = JSONHelper.JSONToObject<InventoryRecord>(body);
            inventoryRecord.InOrOut = false;
            inventoryRecord.LogBy = user.Id;
            inventoryRecord.LogOn = DateTime.Now;

            InventoryRecord res = stockService.createFixtureRecord(inventoryRecord);

            if (res != null)
                return JSONHelper.ObjectToJSON(ResponseUtil.Ok(res));
            else return JSONHelper.ObjectToJSON(ResponseUtil.Fail());
        }

        /// <summary>
        /// 创建一条出库记录
        /// </summary>
        /// <param name="body">工夹具类</param>
        /// <returns></returns>
        [HttpPost]
        public string CreateFixtureOutRecord(string body)
        {
            string token = TokenHelper.GetTokenJson(HttpContext.Request.Headers["Authorization"]);
            TokenInfo tokenInfo = JSONHelper.JSONToObject<TokenInfo>(token);
            User temp = new User();
            temp.Name = tokenInfo.UserName;
            User user = userService.getUserByName(temp);

            InventoryRecord inventoryRecord = JSONHelper.JSONToObject<InventoryRecord>(body);
            inventoryRecord.InOrOut = true;
            inventoryRecord.LogBy = user.Id;
            inventoryRecord.LogOn = DateTime.Now;
            InventoryRecord res = stockService.createFixtureRecord(inventoryRecord);

            if (res != null)
                return JSONHelper.ObjectToJSON(ResponseUtil.Ok(res));
            else return JSONHelper.ObjectToJSON(ResponseUtil.Fail());
        }

        /// <summary>
        /// 通过id获取记录详情
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        [HttpGet]
        public string GetRecordDetailById(int id)
        {
            string token = TokenHelper.GetTokenJson(HttpContext.Request.Headers["Authorization"]);//利用这个进行数据按部门进行隔离
            TokenInfo tokenInfo = JSONHelper.JSONToObject<TokenInfo>(token);
            int WorkcellId = tokenInfo.workCell;
            InventoryRecord record = new InventoryRecord();
            record.WorkcellId = WorkcellId;
            record.Id = id;
            InventoryRecord inventoryRecord = stockService.getRecordDetailById(record);
            return JSONHelper.ObjectToJSON(ResponseUtil.Ok(inventoryRecord));
        }

        /// <summary>
        /// 获取工夹具出入库报表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string GetRecordInOutChart()
        {
            string token = TokenHelper.GetTokenJson(HttpContext.Request.Headers["Authorization"]);//利用这个进行数据按部门进行隔离
            TokenInfo tokenInfo = JSONHelper.JSONToObject<TokenInfo>(token);
            int WorkcellId = tokenInfo.workCell;
            InventoryRecord record = new InventoryRecord();
            record.WorkcellId = WorkcellId;
            List<InventoryRecord> InventoryRecordList = stockService.getInventoryRecordList(record);
            return JSONHelper.ObjectToJSON(ResponseUtil.Ok(InventoryRecordList));
        }

        /// <summary>
        /// 搜索一条出入库记录
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        [HttpGet]
        public string SearchRecordInOut(string workcellName, string handleBy, string code)
        {
            // TODO： 有疑问
            return null;
        }

        /// <summary>
        /// 删除一条出入库记录
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        [HttpPost]
        public string DeleteRecordById(int id)
        {
            string token = TokenHelper.GetTokenJson(HttpContext.Request.Headers["Authorization"]);//利用这个进行数据按部门进行隔离
            TokenInfo tokenInfo = JSONHelper.JSONToObject<TokenInfo>(token);

            InventoryRecord record = new InventoryRecord();
            record.Id = id;
            record.WorkcellId = tokenInfo.workCell;

            int status = stockService.deleteRecordById(record);
            if (1 == status)
                return JSONHelper.ObjectToJSON(ResponseUtil.Ok());
            else
                return JSONHelper.ObjectToJSON(ResponseUtil.Fail());
        }

    }
}
