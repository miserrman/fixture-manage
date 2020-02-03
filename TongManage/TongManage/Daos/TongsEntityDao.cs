using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TongManage.Models;

namespace TongManage.Daos
{
    public class TongsEntityDao
    {
        public IList<TongsEntity> selectAllTongsEntitys()
        {
            return BaseDao.QueryForList<TongsEntity>("SelectAllTongsEntitys");
        }

        public TongsEntity selectTongsEntityById(int id)
        {
            return BaseDao.SelectById<TongsEntity>("SelectTongsEntityById", id);
        }

        public int insertTongsEntity(TongsEntity tongsEntity)
        {
            return BaseDao.Insert<TongsEntity>("InsertTongsEntity", tongsEntity);
        }

        public int updateTongsEntity(TongsEntity tongsEntity)
        {
            return BaseDao.Update<TongsEntity>("UpdateTongsEntity", tongsEntity);
        }

        public int deleteTongsEntityById(int id)
        {
            return BaseDao.Delete("DeleteTongsEntityById", id);
        }
    }
}