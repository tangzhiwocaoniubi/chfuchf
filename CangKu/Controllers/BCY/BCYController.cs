using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MODEL;
using BLL.BCY;

namespace CangKu.Controllers.BCY
{
    public class BCYController : Controller
    {
        // GET: BCY
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult queryAllsupplier()
        {
            return Json(locationManager.queryAllsupplier(),JsonRequestBehavior.AllowGet);
        }
    }
}