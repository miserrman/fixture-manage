using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TongManage.Models;

namespace TongManage.Daos
{
    public class ScrapDao
    {
        public IList<Scrap> selectAllScraps()
        {
            return BaseDao.QueryForList<Scrap>("SelectAllScraps");
        }

        public Scrap selectScrapById(int id)
        {
            return BaseDao.SelectById<Scrap>("SelectScrapById", id);
        }

        public int insertScrap(Scrap scrap)
        {
            return BaseDao.Insert<Scrap>("InsertScrap", scrap);
        }

        public int updateScrap(Scrap scrap)
        {
            return BaseDao.Update<Scrap>("UpdateScrap", scrap);
        }

        public int deleteScrapById(int id)
        {
            return BaseDao.Delete("DeleteScrapById", id);
        }
    }
}