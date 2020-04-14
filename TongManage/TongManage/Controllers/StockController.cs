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

        /// <summary>
        /// 创建一条入库记录
        /// </summary>
        /// <param name="body">工夹具类</param>
        /// <returns></returns>
        [HttpPost]
        public string CreateFixtureInRecord(string body)
        {
            InventoryRecord inventoryRecord = JSONHelper.JSONToObject<InventoryRecord>(body);
            inventoryRecord.InOrOut = false;
            stockService.createFixtureRecord(inventoryRecord);
            return JSONHelper.ObjectToJSON(ResponseUtil.Ok(inventoryRecord));
        }

        /// <summary>
        /// 创建一条出库记录
        /// </summary>
        /// <param name="body">工夹具类</param>
        /// <returns></returns>
        [HttpPost]
        public string CreateFixtureOutRecord(string body)
        {
            InventoryRecord inventoryRecord = JSONHelper.JSONToObject<InventoryRecord>(body);
            inventoryRecord.InOrOut = true;
            stockService.createFixtureRecord(inventoryRecord);
            return JSONHelper.ObjectToJSON(ResponseUtil.Ok(inventoryRecord));
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
        [HttpDelete]
        public string DeleteRecordById(int id)
        {
            InventoryRecord record = new InventoryRecord();
            record.Id = id;
            int status = stockService.deleteRecordById(record);
            if (1 == status)
                return JSONHelper.ObjectToJSON(ResponseUtil.Ok());
            else
                return JSONHelper.ObjectToJSON(ResponseUtil.Fail());
        }

    }
}
