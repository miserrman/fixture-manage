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
    public class ProductionLineDao
    {
        /// <summary>
        /// 查看所有生产线信息
        /// </summary>
        /// <param name="productionLine"></param>
        /// <returns>生产线信息列表</returns>
        public IList<ProductionLine> selectAllProductionLines(ProductionLine productionLine)
        {
            return BaseDao.QueryForList<ProductionLine>("SelectAllProductionLines", productionLine);
        }

        /// <summary>
        /// 查询单条生产线信息
        /// </summary>
        /// <param name="productionLine"></param>
        /// <returns>单条生产线信息记录</returns>
        public ProductionLine selectProductionLineById(ProductionLine productionLine)
        {
            return BaseDao.QueryForObject<ProductionLine>("SelectProductionLineById", productionLine);
        }

        /// <summary>
        /// 插入单条生产线信息
        /// </summary>
        /// <param name="productionLine">生产线类</param>
        /// <returns>操作状态码</returns>
        public int insertProductionLine(ProductionLine productionLine)
        {
            return BaseDao.Insert<ProductionLine>("InsertProductionLine", productionLine);
        }

        /// <summary>
        /// 更新单条生产线信息
        /// </summary>
        /// <param name="productionLine">生产线类</param>
        /// <returns>操作状态码</returns>
        public int updateProductionLine(ProductionLine productionLine)
        {
            return BaseDao.Update<ProductionLine>("UpdateProductionLine", productionLine);
        }

        /// <summary>
        /// 删除单条生产线信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns>操作状态码</returns>
        public int deleteProductionLineById(ProductionLine productionLine)
        {
            return BaseDao.Delete<ProductionLine>("DeleteProductionLineById", productionLine);
        }
    }
}