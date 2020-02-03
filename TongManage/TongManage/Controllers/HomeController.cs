using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TongManage.Attribute;
using TongManage.Daos;
using TongManage.Utils;

namespace TongManage.Controllers
{
    public class HomeController : Controller
    {
        [CheckAttribute(1)]
        public string Index()//此方法需要进行token验证
        {
            InventoryRecordDao inventoryRecordDao = new InventoryRecordDao();
            inventoryRecordDao.selectAllInventoryRecords();
            return "success!";
        }

        [CheckAttribute(0)]
        public string About()//此方法不需要进行token验证
        {
            return "success!";
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}