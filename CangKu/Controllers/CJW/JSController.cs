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
        public ActionResult JSCX()
        {
            JSBLL qw = new JSBLL();
            List<Staff> q = qw.GetAll();

            return View(q);
        }
    }
}