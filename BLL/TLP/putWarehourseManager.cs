using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
using DAL.TLP;
namespace BLL.TLP
{
    public class putWarehourseManager
    {
        //查询全部信息
        public static IQueryable GetputWaAll()
        {
            return putWarehourseService.GetputWaAll();
        }
        //删除
        public static int Del(string receiptNum)
        {
            return putWarehourseService.Del(receiptNum);
        }
    }
}
