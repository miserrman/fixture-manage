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
    public class ScrapDao
    {
        /// <summary>
        /// 查询所有报废信息
        /// </summary>
        /// <param name="scrap"></param>
        /// <returns>夹具报废记录列表</returns>
        public IList<Scrap> selectAllScraps(Scrap scrap)
        {
            return BaseDao.QueryForList<Scrap>("SelectAllScraps", scrap);
        }

        /// <summary>
        /// 查询单条夹具报废信息
        /// </summary>
        /// <param name="scrap"></param>
        /// <returns>单条夹具报废信息</returns>
        public Scrap selectScrapById(Scrap scrap)
        {
            return BaseDao.QueryForObject<Scrap>("SelectScrapById", scrap);
        }

        /// <summary>
        /// 插入单条报废记录
        /// </summary>
        /// <param name="scrap"></param>
        /// <returns>操作状态码</returns>
        public int insertScrap(Scrap scrap)
        {
            return BaseDao.Insert<Scrap>("InsertScrap", scrap);
        }

        /// <summary>
        /// 更新单条报废记录
        /// </summary>
        /// <param name="scrap"></param>
        /// <returns>操作状态码</returns>
        public int updateScrap(Scrap scrap)
        {
            return BaseDao.Update<Scrap>("UpdateScrap", scrap);
        }

        /// <summary>
        /// 删除单条报废信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns>操作状态码</returns>
        public int deleteScrapById(Scrap scrap)
        {
            return BaseDao.Delete<Scrap>("DeleteScrapById", scrap);
        }
    }
}