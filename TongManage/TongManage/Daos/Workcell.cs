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
    public class WorkcellDao
    {
        /// <summary>
        /// 查询所有部门信息
        /// </summary>
        /// <param name="workcell"></param>
        /// <returns>部分信息列表</returns>
        public IList<Workcell> selectAllWorkcells(Workcell workcell)
        {
            return BaseDao.QueryForList<Workcell>("SelectAllWorkcells", workcell);
        }

        /// <summary>
        /// 查询单条部门信息
        /// </summary>
        /// <param name="workcell"></param>
        /// <returns>单个部门信息记录</returns>
        public Workcell selectWorkcellById(Workcell workcell)
        {
            return BaseDao.QueryForObject<Workcell>("SelectWorkcellById", workcell);
        }

        /// <summary>
        /// 插入单条部门信息
        /// </summary>
        /// <param name="workcell"></param>
        /// <returns>操作状态码</returns>
        public int insertWorkcell(Workcell workcell)
        {
            return BaseDao.Insert<Workcell>("InsertWorkcell", workcell);
        }

        /// <summary>
        /// 更新单条部门信息
        /// </summary>
        /// <param name="workcell"></param>
        /// <returns>操作状态码</returns>
        public int updateWorkcell(Workcell workcell)
        {
            return BaseDao.Update<Workcell>("UpdateWorkcell", workcell);
        }

        /// <summary>
        /// 删除单条部门信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns>操作状态码</returns>
        public int deleteWorkcellById(Workcell workcell)
        {
            return BaseDao.Delete<Workcell>("DeleteWorkcellById", workcell);
        }
    }
}