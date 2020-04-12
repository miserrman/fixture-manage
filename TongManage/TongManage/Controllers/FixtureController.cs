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

        /// <summary>
        /// 创建工具夹类别
        /// </summary>
        /// <param name="body">工具夹类别类</param>
        /// <returns></returns>
        [HttpPost]
        public string CreateDef(string body)
        {
            TongsDefinition tongsDefinition = JSONHelper.JSONToObject<TongsDefinition>(body);
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
            TongsDefinition tongsDefinition = JSONHelper.JSONToObject<TongsDefinition>(body);
            tongsDefinition.Id = id;
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
            string token = HttpContext.Request.Headers["Authorization"];//利用这个进行数据按部门进行隔离
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
            string token = HttpContext.Request.Headers["Authorization"];//利用这个进行数据按部门进行隔离
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
            // TODO: 购买请求
            return null;
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
            // TODO: 报废方法
            return null;
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
            // TODO: 维修方法
            return null;
        }

        /// <summary>
        /// 购买请求响应方法
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        [HttpPut]
        public string PurchaseResponse(int id, string body)
        {
            return null;
        }

        /// <summary>
        /// 报废请求响应方法
        /// </summary>
        /// <param name="id"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        [HttpPut]
        public string ScrapResponse(int id, string body)
        {
            // TODO: 报废方法
            return null;
        }

        /// <summary>
        /// 维修请求响应方法
        /// </summary>
        /// <param name="id"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        [HttpPut]
        public string MaintainResponse(int id, string body)
        {
            // TODO: 维修方法
            return null;
        }
    }
}
