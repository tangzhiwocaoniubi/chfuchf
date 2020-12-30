using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
using DAL.CJW;
namespace BLL.CJW
{

    public class JSBLL
    {
        JSDAL q = new JSDAL();
        public List<Staff> GetAll()
        {
            return q.GetAll();
        }


    }
}
