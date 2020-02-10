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
            tongsDefinition = fixtureService.updateTongsDefinition(id, tongsDefinition);
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
            TongsDefinition tongsDefinition = fixtureService.getTongsDefinitionById(id);
            return JSONHelper.ObjectToJSON(ResponseUtil.Ok(tongsDefinition));
        }

        /// <summary>
        /// 获取工具夹报表文件
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string GetDefChart()
        {
            List<TongsDefinition> tongsDefinitionList = fixtureService.getAllTongsDefinitions();
            return JSONHelper.ObjectToJSON(ResponseUtil.Ok(tongsDefinitionList));
        }
      
        //TODO: 删除方法？？
    }
}
