using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;

namespace DAL.TZ
{
   public class LoginDAL
    {
        CKSJKEntities ck = new CKSJKEntities();
        public List<Staff> Login(string username, string userpwd)
        {

            return ck.Staff.Where(p => p.LoginName == username && p.loginPwd == userpwd).ToList();
        }
    }
}
