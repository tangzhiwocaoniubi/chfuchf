using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;

namespace DAL.TZ
{
    public class BaoBiaoDAL
    {
        CKSJKEntities ck = new CKSJKEntities();
        public List<Location>KuCun()
        {
            return ck.Location.ToList();
        }
    }
}
