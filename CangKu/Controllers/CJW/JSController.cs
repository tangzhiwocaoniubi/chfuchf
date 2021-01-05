using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.CJW;
using MODEL;
namespace CangKu.Controllers.CJW
{
    public class JSController : Controller
    {
        // GET: JS
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 主页面
        /// </summary>
        /// <returns></returns>
        public ActionResult YGGL() {
            JSBLL qw = new JSBLL();
            List<Staff> q = qw.GetAll();

            return View(q);
        }
        //新增页面试图
        public ActionResult insert()
        {
            return View();
        }
    }
}