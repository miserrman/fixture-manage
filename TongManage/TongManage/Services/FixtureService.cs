using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TongManage.Daos;
using TongManage.Models;
using TongManage.Models.Vo;
using TongManage.Utils;

namespace TongManage.Services
{
    /// <summary>
    /// Fixture Service类
    /// author: linlianhui
    /// date: 2020/2/8
    /// </summary>
    public class FixtureService
    {
        private static TongsDefinitionDao tongsDefinitionDao = new TongsDefinitionDao();
        private static PurchaseDao purchaseDao = new PurchaseDao();
        private static ScrapDao scrapDao = new ScrapDao();
        private static RepairRecordDao repairRecordDao = new RepairRecordDao();
        private static TongsEntityDao tongsEntityDao = new TongsEntityDao();
        private static StockService stockService = new StockService();
        private static InventoryRecordDao inventoryRecordDao = new InventoryRecordDao();

        /// <summary>
        /// 创建一个工夹具类别
        /// </summary>
        /// 
        /// <param name="tongsDefinition">工夹具类别类</param>
        /// <returns>刚创建的工夹具类别</returns>
        public TongsDefinition createTongsDefinition(TongsDefinition tongsDefinition)
        {
            tongsDefinition.GmtCreate = DateTime.Now.ToLocalTime();
            tongsDefinition.GmtModified = DateTime.Now.ToLocalTime();
            tongsDefinitionDao.insertTongsDefinition(tongsDefinition);
            return tongsDefinition;
        }

        /// <summary>
        /// 更新一个工夹具类别
        /// </summary>
        /// 
        /// <param name="id"></param>
        /// <param name="tongsDefinition">工夹具类别类</param>
        /// <returns>刚更新的工夹具类别或空（更新失败）</returns>
        public TongsDefinition updateTongsDefinition(TongsDefinition tongsDefinition)
        {
            TongsDefinition temp = tongsDefinitionDao.selectTongsDefinitionById(tongsDefinition);
            tongsDefinition.GmtCreate = temp.GmtCreate;
            tongsDefinition.GmtModified = DateTime.Now.ToLocalTime();
            int status = tongsDefinitionDao.updateTongsDefinition(tongsDefinition);
            if (1 == status)
            {
                return tongsDefinition;
            }
            else
            {
                return null;
            }       
        }

        /// <summary>
        /// 通过ID查找工夹具类别
        /// </summary>
        /// 
        /// <param name="id"></param>
        /// <returns>查找到的工夹具类别</returns>
        public TongsDefinition getTongsDefinitionById(TongsDefinition definition)
        {
            return tongsDefinitionDao.selectTongsDefinitionById(definition);
        }

        /// <summary>
        /// 查找所有的工夹具类别
        /// </summary>
        /// 
        /// <returns>工夹具类别列表</returns>
        public List<TongsDefinition> getAllTongsDefinitions(TongsDefinition definition)
        {
            return tongsDefinitionDao.selectAllTongsDefinitions(definition).ToList<TongsDefinition>();
        }

        /// <summary>
        ///  购买请求方法
        /// </summary>
        /// <param name="purchase"></param>
        /// <returns></returns>
        public Purchase PurhaseRequest(Purchase purchase)
        {
            purchase.GmtCreate = DateTime.Now.ToLocalTime();
            purchase.GmtModified = DateTime.Now.ToLocalTime();
            purchase.Status = 0;
            if (purchaseDao.insertPurchase(purchase) == 1)
                return purchase;
            else return null;
        }

        /// <summary>
        /// 报废请求方法
        /// </summary>
        /// <param name="scrap"></param>
        /// <returns></returns>
        public Scrap ScrapRequest(Scrap scrap)
        {
            scrap.GmtCreate = DateTime.Now.ToLocalTime();
            scrap.GmtModified = DateTime.Now.ToLocalTime();
            scrap.Status = 0;
            if (scrapDao.updateScrap(scrap) == 1)
                return scrap;
            return null;
        }

        /// <summary>
        ///  维修请求方法
        /// </summary>
        /// <param name="repairRecord"></param>
        /// <returns></returns>
        public RepairRecord MaintainRequest(RepairRecord repairRecord)
        {
            repairRecord.GmtCreate = DateTime.Now.ToLocalTime();
            repairRecord.GmtModified = DateTime.Now.ToLocalTime();
            repairRecord.Status = 0;
            if (repairRecordDao.updateRepairRecord(repairRecord) == 1)
                return repairRecord;
            return null;
        }

        /// <summary>
        ///  更新购买记录状态方法
        /// </summary>
        /// <param name="purchase"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public Purchase UpdatePurchaseStatus(Purchase purchase, int status)
        {
            purchase.GmtCreate = DateTime.Now.ToLocalTime();
            purchase.GmtModified = DateTime.Now.ToLocalTime();
            purchase.Status = status;
            if (purchaseDao.updatePurchase(purchase) == 1)
            {
                if (3 == status)
                {
                    CreateInventoryInRecord(purchase);
                }
                return purchase;
            } 
            else return null;
        }

        /// <summary>
        ///  更新报废记录状态方法
        /// </summary>
        /// <param name="scrap"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public Scrap UpdateScrapStatus(Scrap scrap, int status)
        {
            scrap.GmtCreate = DateTime.Now.ToLocalTime();
            scrap.GmtModified = DateTime.Now.ToLocalTime();
            scrap.Status = status;
            if (scrapDao.updateScrap(scrap) == 1)
                return scrap;
            return null;
        }

        /// <summary>
        ///  更新维修记录状态方法
        /// </summary>
        /// <param name="repairRecord"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public RepairRecord UpdateRepairRecordStatus(RepairRecord repairRecord, int status)
        {
            repairRecord.GmtCreate = DateTime.Now.ToLocalTime();
            repairRecord.GmtModified = DateTime.Now.ToLocalTime();
            repairRecord.Status = status;
            if (repairRecordDao.updateRepairRecord(repairRecord) == 1)
                return repairRecord;
            return null;
        }

        /// <summary>
        /// 根据采购记录创建一条入库记录
        /// </summary>
        /// <param name="purchase"></param>
        /// <returns></returns>
        private bool CreateInventoryInRecord(Purchase purchase)
        {
            // TODO: 有待商榷
            InventoryRecord inventoryRecord = new InventoryRecord();
            inventoryRecord.InOrOut = false;

            return true;
        }
        /// <summary>
        /// 获取所有工具夹实体
        /// </summary>
        /// <param name="tongsEntity"></param>
        /// <returns></returns>
        public List<TongsEntityVo> GetTongsEntities(TongsEntity tongsEntity)
        {
            List <TongsEntity> tongsList=tongsEntityDao.selectAllTongsEntitys(tongsEntity).ToList();
            List<TongsEntityVo> result = new List<TongsEntityVo>(tongsList.Count());
            for(int i=0;i< tongsList.Count();i++)
            {
                TongsDefinition p = new TongsDefinition();
                p.Code = tongsList[i].Code;
                TongsDefinition tongsDefinition = tongsDefinitionDao.selectTongsDefinitionByCode(p);
                var ParentType = typeof(TongsEntity);
                var Properties = ParentType.GetProperties();
                foreach (var Propertie in Properties)
                {
                    if (Propertie.CanRead && Propertie.CanWrite)
                    {
                        Propertie.SetValue(result[i], Propertie.GetValue(tongsList[i], null), null);
                    }
                }
                result[i].FamilyId = tongsDefinition.FamilyId;
                result[i].Name = tongsDefinition.Name;
                result[i].Model = tongsDefinition.Model;
                result[i].PartNo = tongsDefinition.PartNo;
                result[i].UserdFor = tongsDefinition.UserdFor;
                result[i].Upl = tongsDefinition.Upl;
                result[i].OwnerId = tongsDefinition.OwnerId;
                result[i].Remark = tongsDefinition.Remark;
                result[i].PmPeriod = tongsDefinition.PmPeriod;
            }
            return result;
        }
        /// <summary>
        /// 获取特定的工具夹实体
        /// </summary>
        /// <param name="tongsEntity"></param>
        /// <returns></returns>
        public TongsEntityVo GetTongsEntity(TongsEntity tongsEntity)
        {
            TongsEntityVo result = new TongsEntityVo();
            TongsEntity tongs = tongsEntityDao.selectTongsEntityByCodeAndSeq(tongsEntity);
            TongsDefinition p = new TongsDefinition();
            p.Code = tongs.Code;
            TongsDefinition tongsDefinition = tongsDefinitionDao.selectTongsDefinitionByCode(p);
            var ParentType = typeof(TongsEntity);
            var Properties = ParentType.GetProperties();
            foreach (var Propertie in Properties)
            {
                if (Propertie.CanRead && Propertie.CanWrite)
                {
                    Propertie.SetValue(result, Propertie.GetValue(tongs, null), null);
                }
            }
            result.FamilyId = tongsDefinition.FamilyId;
            result.Name = tongsDefinition.Name;
            result.Model = tongsDefinition.Model;
            result.PartNo = tongsDefinition.PartNo;
            result.UserdFor = tongsDefinition.UserdFor;
            result.Upl = tongsDefinition.Upl;
            result.OwnerId = tongsDefinition.OwnerId;
            result.Remark = tongsDefinition.Remark;
            result.PmPeriod = tongsDefinition.PmPeriod;
            return result;
        }

        /// <summary>
        ///  获取工夹具的所有信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="workcellId"></param>
        /// <returns></returns>
        public FixtureInfoVo GetFixtureInfoById(int id, int workcellId)
        {
            FixtureInfoVo fixtureInfoVo = new FixtureInfoVo();

            TongsEntity tETemp = new TongsEntity();
            tETemp.Id = id;
            tETemp.WorkcellId = workcellId;
            TongsEntity tongsEntity = tongsEntityDao.selectTongsEntityById(tETemp);
            //LogHelper.WriteLog(typeof(String), tongsEntity.ToString());
            if (null == tongsEntity) return null;

            TongsDefinition tDTemp = new TongsDefinition();
            tDTemp.Code = tongsEntity.Code;
            tDTemp.WorkcellId = tongsEntity.WorkcellId;
            TongsDefinition tongsDefinition = tongsDefinitionDao.selectTongsDefinitionByCode(tDTemp);

            InventoryRecord iRTemp = new InventoryRecord();
            iRTemp.TongId = tongsEntity.Id;
            iRTemp.WorkcellId = tongsEntity.WorkcellId;
            LogHelper.WriteLog(typeof(String), JSONHelper.ObjectToJSON(iRTemp));
            List<InventoryRecord> inventoryRecords = inventoryRecordDao.selectAllInventoryRecords(iRTemp).ToList<InventoryRecord>();

            RepairRecord rRTemp = new RepairRecord();
            rRTemp.TongId = tongsEntity.Id;
            rRTemp.WorkcellId = tongsEntity.WorkcellId;
            LogHelper.WriteLog(typeof(String), JSONHelper.ObjectToJSON(rRTemp));
            List<RepairRecord> repairRecords = repairRecordDao.selectAllRepairRecords(rRTemp).ToList<RepairRecord>();

            fixtureInfoVo.TongsEntity = tongsEntity;
            fixtureInfoVo.TongsDefinition = tongsDefinition;
            fixtureInfoVo.InventoryRecords = inventoryRecords;
            fixtureInfoVo.RepairRecords = repairRecords;

            return fixtureInfoVo;
    }
    }
}