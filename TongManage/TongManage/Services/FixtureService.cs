using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TongManage.Daos;
using TongManage.Models;

namespace TongManage.Services
{
    /// <summary>
    /// Fixture Service类
    /// author: linlianhui
    /// date: 2020/2/8
    /// </summary>
    public class FixtureService
    {
        private static TongsDefinitionDao tongsDefinitionDao = new TongsDefinitionDao();

        /// <summary>
        /// 创建一个工夹具类别
        /// </summary>
        /// 
        /// <param name="tongsDefinition">工夹具类别类</param>
        /// <returns>刚创建的工夹具类别</returns>
        public TongsDefinition createTongsDefinition(TongsDefinition tongsDefinition)
        {
            tongsDefinition.GmtCreate = DateTime.Now.ToLocalTime();
            tongsDefinition.GmtModified = DateTime.Now.ToLocalTime();
            tongsDefinitionDao.insertTongsDefinition(tongsDefinition);
            return tongsDefinition;
        }

        /// <summary>
        /// 更新一个工夹具类别
        /// </summary>
        /// 
        /// <param name="id"></param>
        /// <param name="tongsDefinition">工夹具类别类</param>
        /// <returns>刚更新的工夹具类别或空（更新失败）</returns>
        public TongsDefinition updateTongsDefinition(int id, TongsDefinition tongsDefinition)
        {
            TongsDefinition temp = tongsDefinitionDao.selectTongsDefinitionById(id);
            tongsDefinition.Id = id;
            tongsDefinition.GmtCreate = temp.GmtCreate;
            tongsDefinition.GmtModified = DateTime.Now.ToLocalTime();
            int status = tongsDefinitionDao.updateTongsDefinition(tongsDefinition);
            if (1 == status)
            {
                return tongsDefinition;
            }
            else
            {
                return null;
            }       
        }

        /// <summary>
        /// 通过ID查找工夹具类别
        /// </summary>
        /// 
        /// <param name="id"></param>
        /// <returns>查找到的工夹具类别</returns>
        public TongsDefinition getTongsDefinitionById(int id)
        {
            return tongsDefinitionDao.selectTongsDefinitionById(id);
        }

        /// <summary>
        /// 查找所有的工夹具类别
        /// </summary>
        /// 
        /// <returns>工夹具类别列表</returns>
        public List<TongsDefinition> getAllTongsDefinitions()
        {
            return tongsDefinitionDao.selectAllTongsDefinitions().ToList<TongsDefinition>();
        }
    }
}