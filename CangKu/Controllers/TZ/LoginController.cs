using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MODEL;
using BLL.TZ;
namespace CangKu.Controllers.TZ
{
    public class LoginController : Controller
    {
        // GET: Login
       
        BLL.TZ.LoginBLL bll = new BLL.TZ.LoginBLL();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {

            return View();
        }
        public ActionResult IsLogin(string username, string userpwd)
        {

            if (bll.Login(username, userpwd).Count > 0)
            {
                Session["username"] = bll.Login(username, userpwd).ElementAt(0).LoginName;
                return Content("1");
            }
            else
            {
                return Content("0");
            }
        }
    }
}