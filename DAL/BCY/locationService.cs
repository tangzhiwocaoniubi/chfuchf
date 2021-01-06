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
        /// <summary>
        /// 库位表
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// 供应商表
        /// </summary>
        /// <returns></returns>
        public static IQueryable queryAllsupplier()
        {
            CKSJKEntities entit = new CKSJKEntities();
            var obj = from p in entit.supplier
                      select new
                      {
                          supplierNum = p.supplierNum,
                          supplierName = p.supplierName,
                          supplierLeix = p.supplierLeix,
                          phone = p.phone,
                          chuanzhen = p.chuanzhen,
                          email = p.email,
                          contacts = p.contacts,
                          address = p.address,
                          contents = p.contents,
                          isDel = p.isDel
                      };
            return obj;
        }
    }
}
