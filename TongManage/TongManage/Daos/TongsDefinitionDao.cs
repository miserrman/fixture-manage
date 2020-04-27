using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TongManage.Models;

namespace TongManage.Daos
{
    /// <summary>
    /// author: rentianhe
    /// date: 2020/2/3
    /// </summary>
    public class TongsDefinitionDao
    {
        /// <summary>
        /// 查询所有夹具定义
        /// </summary>
        /// <param name="tongsDefinition"></param>
        /// <returns>库存记录列表</returns>
        public IList<TongsDefinition> selectAllTongsDefinitions(TongsDefinition tongsDefinition)
        {
            return BaseDao.QueryForList<TongsDefinition>("SelectAllTongsDefinitions", tongsDefinition);
        }

        /// <summary>
        /// 查询单条夹具定义信息
        /// </summary>
        /// <param name="tongsDefinition"></param>
        /// <returns>单条夹具定义信息</returns>
        public TongsDefinition selectTongsDefinitionById(TongsDefinition tongsDefinition)
        {
            return BaseDao.QueryForObject<TongsDefinition>("SelectTongsDefinitionById", tongsDefinition);
        }
        /// <summary>
        /// 查询单条夹具定义信息
        /// </summary>
        /// <param name="tongsDefinition"></param>
        /// <returns>单条夹具定义信息</returns>
        public TongsDefinition selectTongsDefinitionByCode(TongsDefinition tongsDefinition)
        {
            return BaseDao.QueryForObject<TongsDefinition>("SelectTongsDefinitionByCode", tongsDefinition);
        }
        /// <summary>
        /// 插入单条夹具定义
        /// </summary>
        /// <param name="tongsDefinition"></param>
        /// <returns>操作状态码</returns>
        public int insertTongsDefinition(TongsDefinition tongsDefinition)
        {
            return BaseDao.Insert<TongsDefinition>("InsertTongsDefinition", tongsDefinition);
        }

        /// <summary>
        /// 更新单条夹具定义
        /// </summary>
        /// <param name="tongsDefinition"></param>
        /// <returns>操作状态码</returns>
        public int updateTongsDefinition(TongsDefinition tongsDefinition)
        {
            return BaseDao.Update<TongsDefinition>("UpdateTongsDefinition", tongsDefinition);
        }

        /// <summary>
        /// 删除单条夹具定义
        /// </summary>
        /// <param name="id"></param>
        /// <returns>操作状态码</returns>
        public int deleteTongsDefinitionById(TongsDefinition tongsDefinition)
        {
            return BaseDao.Delete<TongsDefinition>("DeleteTongsDefinitionById", tongsDefinition);
        }
    }
}