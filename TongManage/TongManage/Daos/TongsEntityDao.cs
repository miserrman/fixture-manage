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
    public class TongsEntityDao
    {
        /// <summary>
        /// 查询所有夹具实体内容
        /// </summary>
        /// <param name="tongsEntity"></param>
        /// <returns>夹具实体列表</returns>
        public IList<TongsEntity> selectAllTongsEntitys(TongsEntity tongsEntity)
        {
            return BaseDao.QueryForList<TongsEntity>("SelectAllTongsEntitys", tongsEntity);
        }

        /// <summary>
        /// 查询单条夹具实体
        /// </summary>
        /// <param name="tongsEntity"></param>
        /// <returns>单个夹具实体信息</returns>
        public TongsEntity selectTongsEntityById(TongsEntity tongsEntity)
        {
            return BaseDao.QueryForObject<TongsEntity>("SelectTongsEntityById", tongsEntity);
        }

        /// <summary>
        /// 插入单条夹具实体内容
        /// </summary>
        /// <param name="tongsEntity"></param>
        /// <returns>操作状态码</returns>
        public int insertTongsEntity(TongsEntity tongsEntity)
        {
            return BaseDao.Insert<TongsEntity>("InsertTongsEntity", tongsEntity);
        }

        /// <summary>
        /// 更新单条夹具实体内容
        /// </summary>
        /// <param name="tongsEntity"></param>
        /// <returns>操作状态码</returns>
        public int updateTongsEntity(TongsEntity tongsEntity)
        {
            return BaseDao.Update<TongsEntity>("UpdateTongsEntity", tongsEntity);
        }

        /// <summary>
        /// 删除单条夹具实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns>操作状态码</returns>
        public int deleteTongsEntityById(TongsEntity tongsEntity)
        {
            return BaseDao.Delete<TongsEntity>("DeleteTongsEntityById", tongsEntity);
        }
    }
}