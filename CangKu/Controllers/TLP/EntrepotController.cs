using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.TLP;
using MODEL;
namespace CangKu.Controllers.TLP
{
    public class EntrepotController : Controller
    {
        // GET: Entrepot
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RuKu()
        {
            return View();
        }

        //查询全部信息
        public ActionResult GetputWaAll()
        {
            return Json(putWarehourseManager.GetputWaAll(),JsonRequestBehavior.AllowGet);
        }
        //删除
        public ActionResult Del(string receiptNum)
        {
            return Json(putWarehourseManager.Del(receiptNum),JsonRequestBehavior.AllowGet);
        }
    }
}