using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;

namespace DAL.BCY
{
    public class locationService
    {
        public static IQueryable QueryLocation()
        {
            CKSJKEntities entit = new CKSJKEntities();
            var obj = from p in entit.Location
                      select new
                      {
                          LocationNum = p.LocationNum,
                          LocationName = p.LocationName,
                          warehourseNum = p.warehourseNum,
                          barcode = p.barcode,
                          isDisable = p.isDisable,
                          isDefult = p.isDefult,
                          CreateTime = p.CreateTime,
                          isDel = p.isDel
                      };
            return obj;
        }
    }
}
