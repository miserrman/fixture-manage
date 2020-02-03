using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TongManage.Models;

namespace TongManage.Daos
{
    public class WorkcellDao
    {
        public IList<Workcell> selectAllWorkcells()
        {
            return BaseDao.QueryForList<Workcell>("SelectAllWorkcells");
        }

        public Workcell selectWorkcellById(int id)
        {
            return BaseDao.SelectById<Workcell>("SelectWorkcellById", id);
        }

        public int insertWorkcell(Workcell workcell)
        {
            return BaseDao.Insert<Workcell>("InsertWorkcell", workcell);
        }

        public int updateWorkcell(Workcell workcell)
        {
            return BaseDao.Update<Workcell>("UpdateWorkcell", workcell);
        }

        public int deleteWorkcellById(int id)
        {
            return BaseDao.Delete("DeleteWorkcellById", id);
        }
    }
}