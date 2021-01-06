using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
using DAL.TZ;
namespace BLL.TZ
{
  public  class LoginBLL
    {
        LoginDAL ld = new LoginDAL();
        public List<Staff> Login(string username, string userpwd)
        {

            return ld.Login(username, userpwd);
        }
    }
}
