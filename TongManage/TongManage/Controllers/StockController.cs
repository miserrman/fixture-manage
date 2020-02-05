﻿using System;
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
            stockService.CreateFixtureRecord(inventoryRecord);
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
            stockService.CreateFixtureRecord(inventoryRecord);
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
            InventoryRecord inventoryRecord = stockService.GetRecordDetailById(id);
            return JSONHelper.ObjectToJSON(ResponseUtil.Ok(inventoryRecord));
        }

        /// <summary>
        /// 获取工夹具出入库报表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string GetRecordInOutChart(int id)
        {
            //TODO: 获取报表是什么意思？？
            return null;
        }

        /// <summary>
        /// 搜索一条出入库记录
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        [HttpGet]
        public string GetRecordById(int id)
        {
            //TODO: 与上面的通过ID查找对应的记录详情有什么不同？？
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
            //TODO: 删除的时候需要将被删除的对象返回吗？？
            stockService.DeleteRecordById(id);
            return JSONHelper.ObjectToJSON(ResponseUtil.Ok());
        }

    }
}
