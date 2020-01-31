using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TongManage.Attribute;

namespace TongManage.Controllers
{
    public class HomeController : Controller
    { 
        [Fixture]
        public string Index()
        {
            return "cds";
        }

        public string Create()
        {
            return "create";
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}