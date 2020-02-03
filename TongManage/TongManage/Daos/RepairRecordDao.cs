using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TongManage.Models;

namespace TongManage.Daos
{
    public class RepairRecordDao
    {
        public IList<RepairRecord> selectAllRepairRecords()
        {
            return BaseDao.QueryForList<RepairRecord>("SelectAllRepairRecords");
        }

        public RepairRecord selectRepairRecordById(int id)
        {
            return BaseDao.SelectById<RepairRecord>("SelectRepairRecordById", id);
        }

        public int insertRepairRecord(RepairRecord repairRecord)
        {
            return BaseDao.Insert<RepairRecord>("InsertRepairRecord", repairRecord);
        }

        public int updateRepairRecord(RepairRecord repairRecord)
        {
            return BaseDao.Update<RepairRecord>("UpdateRepairRecord", repairRecord);
        }

        public int deleteRepairRecordById(int id)
        {
            return BaseDao.Delete("DeleteRepairRecordById", id);
        }
    }
}