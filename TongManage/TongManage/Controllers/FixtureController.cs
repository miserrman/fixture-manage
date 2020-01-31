using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Http;
using TongManage.Models;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace TongManage.Controllers
{
    public class FixtureController : Controller
    {
        // GET: Fixture
        public ActionResult Index()
        {
            return View();
        }

        // GET: Fixture/Details/5
        public string Details(int id, string role)
        {
            Role r = JsonConvert.DeserializeObject<Role>(role);
            string res = JsonConvert.SerializeObject(r);
            return res;
        }

        // GET: Fixture/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Fixture/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Fixture/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Fixture/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Fixture/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Fixture/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
