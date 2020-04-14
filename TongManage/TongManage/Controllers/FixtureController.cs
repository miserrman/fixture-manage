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
using TongManage.Services;
using TongManage.Utils;

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

        private static FixtureService fixtureService = new FixtureService();
        private static UserService userService = new UserService();
        /// <summary>
        /// 创建工具夹类别
        /// </summary>
        /// <param name="body">工具夹类别类</param>
        /// <returns></returns>
        [HttpPost]
        public string CreateDef(string body)
        {
            string token = TokenHelper.GetTokenJson(HttpContext.Request.Headers["Authorization"]);
            TokenInfo tokenInfo = JSONHelper.JSONToObject<TokenInfo>(token);
            User p = new User();
            p.Name = tokenInfo.UserName;
            User user = userService.getUserByName(p);
            TongsDefinition tongsDefinition = JSONHelper.JSONToObject<TongsDefinition>(body);
            tongsDefinition.RecBy = user.Id;
            tongsDefinition = fixtureService.createTongsDefinition(tongsDefinition);
            return JSONHelper.ObjectToJSON(ResponseUtil.Ok(tongsDefinition));
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
            string token = TokenHelper.GetTokenJson(HttpContext.Request.Headers["Authorization"]);
            TokenInfo tokenInfo = JSONHelper.JSONToObject<TokenInfo>(token);
            User p = new User();
            p.Name = tokenInfo.UserName;
            User user = userService.getUserByName(p);
            TongsDefinition tongsDefinition = JSONHelper.JSONToObject<TongsDefinition>(body);
            tongsDefinition.Id = id;
            tongsDefinition.EditBy = user.Id;
            tongsDefinition = fixtureService.updateTongsDefinition(tongsDefinition);
            if (null == tongsDefinition)
            {
                return JSONHelper.ObjectToJSON(ResponseUtil.Fail());
            }
            else
            {
                return JSONHelper.ObjectToJSON(ResponseUtil.Ok(tongsDefinition));
            }
        }

        /// <summary>
        /// 得到工具夹类别
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public string GetDefById(int id)
        {
            string token = TokenHelper.GetTokenJson(HttpContext.Request.Headers["Authorization"]);//利用这个进行数据按部门进行隔离
            TokenInfo tokenInfo = JSONHelper.JSONToObject<TokenInfo>(token);
            int WorkcellId = tokenInfo.workCell;
            TongsDefinition definition = new TongsDefinition();
            definition.WorkcellId = WorkcellId;
            definition.Id = id;
            TongsDefinition tongsDefinition = fixtureService.getTongsDefinitionById(definition);
            return JSONHelper.ObjectToJSON(ResponseUtil.Ok(tongsDefinition));
        }

        /// <summary>
        /// 获取工具夹报表文件
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string GetDefChart()
        {
            string token = TokenHelper.GetTokenJson(HttpContext.Request.Headers["Authorization"]);//利用这个进行数据按部门进行隔离
            TokenInfo tokenInfo = JSONHelper.JSONToObject<TokenInfo>(token);
            int WorkcellId = tokenInfo.workCell;
            TongsDefinition definition = new TongsDefinition();
            definition.WorkcellId = WorkcellId;
            List<TongsDefinition> tongsDefinitionList = fixtureService.getAllTongsDefinitions(definition);
            return JSONHelper.ObjectToJSON(ResponseUtil.Ok(tongsDefinitionList));
        }

        /// <summary>
        /// 购买请求方法
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        [HttpPost]
        public string PurchaseEntity(string body)
        {
            string token = TokenHelper.GetTokenJson(HttpContext.Request.Headers["Authorization"]);
            TokenInfo tokenInfo = JSONHelper.JSONToObject<TokenInfo>(token);
            User p = new User();
            p.Name = tokenInfo.UserName;
            User user = userService.getUserByName(p);
            Purchase purchase = JSONHelper.JSONToObject<Purchase>(body);
            purchase.OperatorId = user.Id;
            Purchase res = fixtureService.PurhaseRequest(purchase);

            if (res != null)
                return JSONHelper.ObjectToJSON(ResponseUtil.Ok(res));
            else return JSONHelper.ObjectToJSON(ResponseUtil.Fail());
        }

        /// <summary>
        /// 报废请求方法
        /// </summary>
        /// <param name="id"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        [HttpPut]
        public string ScrapEntity(int id, string body)
        {
            string token = TokenHelper.GetTokenJson(HttpContext.Request.Headers["Authorization"]);
            TokenInfo tokenInfo = JSONHelper.JSONToObject<TokenInfo>(token);
            User p = new User();
            p.Name = tokenInfo.UserName;
            User user = userService.getUserByName(p);
            Scrap scrap = JSONHelper.JSONToObject<Scrap>(body);
            scrap.Id = id;
            scrap.OperatorId = user.Id;
            Scrap res = fixtureService.ScrapRequest(scrap);

            if (res != null)
                return JSONHelper.ObjectToJSON(ResponseUtil.Ok(res));
            else return null;
        }

        /// <summary>
        /// 维修请求方法
        /// </summary>
        /// <param name="id"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        [HttpPut]
        public string MaintainEntity(int id, string body)
        {
            RepairRecord repairRecord = JSONHelper.JSONToObject<RepairRecord>(body);
            repairRecord.Id = id;
            RepairRecord res = fixtureService.MaintainRequest(repairRecord);

            if (res != null)
                return JSONHelper.ObjectToJSON(ResponseUtil.Ok(res));
            else return null;
        }

        /// <summary>
        /// 购买记录状态更新
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        [HttpPut]
        public string PurchaseStatus(int id, int status, string body)
        {
            string token = TokenHelper.GetTokenJson(HttpContext.Request.Headers["Authorization"]);
            TokenInfo tokenInfo = JSONHelper.JSONToObject<TokenInfo>(token);
            User p = new User();
            p.Name = tokenInfo.UserName;
            User user = userService.getUserByName(p);
            Purchase purchase = JSONHelper.JSONToObject<Purchase>(body);
            purchase.Id = id;
            purchase.OperatorId = user.Id;
            Purchase res = fixtureService.UpdatePurchaseStatus(purchase, status);

            if (res != null)
                return JSONHelper.ObjectToJSON(ResponseUtil.Ok(res));
            else return JSONHelper.ObjectToJSON(ResponseUtil.Fail());
        }

        /// <summary>
        /// 报废记录状态更新
        /// </summary>
        /// <param name="id"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        [HttpPut]
        public string ScrapStatus(int id, int status, string body)
        {
            string token = TokenHelper.GetTokenJson(HttpContext.Request.Headers["Authorization"]);
            TokenInfo tokenInfo = JSONHelper.JSONToObject<TokenInfo>(token);
            User p = new User();
            p.Name = tokenInfo.UserName;
            User user = userService.getUserByName(p);
            Scrap scrap = JSONHelper.JSONToObject<Scrap>(body);
            scrap.Id = id;
            scrap.OperatorId = user.Id;
            Scrap res = fixtureService.UpdateScrapStatus(scrap, status);

            if (res != null)
                return JSONHelper.ObjectToJSON(ResponseUtil.Ok(res));
            else return JSONHelper.ObjectToJSON(ResponseUtil.Fail());
        }

        /// <summary>
        /// 维修记录状态更新
        /// </summary>
        /// <param name="id"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        [HttpPut]
        public string MaintainStatus(int id, int status, string body)
        {
            RepairRecord repairRecord = JSONHelper.JSONToObject<RepairRecord>(body);
            repairRecord.Id = id;
            RepairRecord res = fixtureService.UpdateRepairRecordStatus(repairRecord, status);

            if (res != null)
                return JSONHelper.ObjectToJSON(ResponseUtil.Ok(res));
            else return JSONHelper.ObjectToJSON(ResponseUtil.Fail());
        }
    }
}
