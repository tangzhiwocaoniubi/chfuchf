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

        public static int YGAdd(Staff w)
        {
            CKSJKEntities q = new CKSJKEntities();
            q.Staff.Add(w);
            return q.SaveChanges();
        }
    }
}
