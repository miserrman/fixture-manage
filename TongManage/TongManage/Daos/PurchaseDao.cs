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
    public class PurchaseDao
    {
        /// <summary>
        /// 查询所有采购信息
        /// </summary>
        /// <param name="purchase"></param>
        /// <returns>采购记录列表</returns>
        public IList<Purchase> selectAllPurchases(Purchase purchase)
        {
            return BaseDao.QueryForList<Purchase>("SelectAllPurchases", purchase);
        }

        /// <summary>
        /// 查询单条采购信息
        /// </summary>
        /// <param name="purchase"></param>
        /// <returns>采购记录</returns>
        public Purchase selectPurchaseById(Purchase purchase)
        {
            return BaseDao.QueryForObject<Purchase>("SelectPurchaseById", purchase);
        }

        /// <summary>
        /// 插入单条采购记录
        /// </summary>
        /// <param name="purchase"></param>
        /// <returns>操作状态码</returns>
        public int insertPurchase(Purchase purchase)
        {
            return BaseDao.Insert<Purchase>("InsertPurchase", purchase);
        }

        /// <summary>
        /// 更新采购信息
        /// </summary>
        /// <param name="purchase"></param>
        /// <returns>操作状态码</returns>
        public int updatePurchase(Purchase purchase)
        {
            return BaseDao.Update<Purchase>("UpdatePurchase", purchase);
        }

        /// <summary>
        /// 删除单条采购信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns>操作状态码</returns>
        public int deletePurchaseById(Purchase purchase)
        {
            return BaseDao.Delete<Purchase>("DeletePurchaseById", purchase);
        }
    }
}