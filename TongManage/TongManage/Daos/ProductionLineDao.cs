using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TongManage.Models;

namespace TongManage.Daos
{
    public class ProductionLineDao
    {
        public IList<ProductionLine> selectAllProductionLines()
        {
            return BaseDao.QueryForList<ProductionLine>("SelectAllProductionLines");
        }

        public ProductionLine selectProductionLineById(int id)
        {
            return BaseDao.SelectById<ProductionLine>("SelectProductionLineById", id);
        }

        public int insertProductionLine(ProductionLine productionLine)
        {
            return BaseDao.Insert<ProductionLine>("InsertProductionLine", productionLine);
        }

        public int updateProductionLine(ProductionLine productionLine)
        {
            return BaseDao.Update<ProductionLine>("UpdateProductionLine", productionLine);
        }

        public int deleteProductionLineById(int id)
        {
            return BaseDao.Delete("DeleteProductionLineById", id);
        }
    }
}