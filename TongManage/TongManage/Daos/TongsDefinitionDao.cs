using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TongManage.Models;

namespace TongManage.Daos
{
    public class TongsDefinitionDao
    {
        public IList<TongsDefinition> selectAllTongsDefinitions()
        {
            return BaseDao.QueryForList<TongsDefinition>("SelectAllTongsDefinitions");
        }

        public TongsDefinition selectTongsDefinitionById(int id)
        {
            return BaseDao.SelectById<TongsDefinition>("SelectTongsDefinitionById", id);
        }

        public int insertTongsDefinition(TongsDefinition tongsDefinition)
        {
            return BaseDao.Insert<TongsDefinition>("InsertTongsDefinition", tongsDefinition);
        }

        public int updateTongsDefinition(TongsDefinition tongsDefinition)
        {
            return BaseDao.Update<TongsDefinition>("UpdateTongsDefinition", tongsDefinition);
        }

        public int deleteTongsDefinitionById(int id)
        {
            return BaseDao.Delete("DeleteTongsDefinitionById", id);
        }
    }
}