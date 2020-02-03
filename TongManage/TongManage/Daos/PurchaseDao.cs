using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TongManage.Models;

namespace TongManage.Daos
{
    public class PurchaseDao
    {
        public IList<Purchase> selectAllPurchases()
        {
            return BaseDao.QueryForList<Purchase>("SelectAllPurchases");
        }

        public Purchase selectPurchaseById(int id)
        {
            return BaseDao.SelectById<Purchase>("SelectPurchaseById", id);
        }

        public int insertPurchase(Purchase purchase)
        {
            return BaseDao.Insert<Purchase>("InsertPurchase", purchase);
        }

        public int updatePurchase(Purchase purchase)
        {
            return BaseDao.Update<Purchase>("UpdatePurchase", purchase);
        }

        public int deletePurchaseById(int id)
        {
            return BaseDao.Delete("DeletePurchaseById", id);
        }
    }
}