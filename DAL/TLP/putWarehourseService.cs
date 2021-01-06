using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
namespace DAL.TLP
{
    public class putWarehourseService
    {
        //查询全部信息
        public static IQueryable GetputWaAll()
        {
            CKSJKEntities ck = new CKSJKEntities();
            var obj = from p in ck.putWarehourse
                      select new
                      {
                          receiptNum = p.receiptNum,
                          receiptTypeNum = p.receiptTypeNum,
                          supplierNum = p.supplierNum,
                          orderNo=p.orderNo,
                          totalNum = p.totalNum,
                          ygNumber = p.ygNumber,
                          examineState = p.examineState,
                          OperationMode = p.OperationMode,
                          createTime = p.createTime
                      };
            return obj;
        }
        //删除
        public static int Del(string receiptNum)
        {
            CKSJKEntities lian = new CKSJKEntities();
            var obj = (from p in lian.putWarehourse where p.receiptNum == receiptNum select p).First();
            lian.putWarehourse.Remove(obj);
            return lian.SaveChanges();
        }
    }
}
