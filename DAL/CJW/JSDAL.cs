using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;

namespace DAL.CJW
{

  public class JSDAL
    {
        
        public List<Staff> GetAll() 
        {
            CKSJKEntities cjw = new CKSJKEntities();
            return cjw.Staff.ToList();
        }
    }
}
