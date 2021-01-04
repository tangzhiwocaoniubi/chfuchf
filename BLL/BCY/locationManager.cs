using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
using DAL.BCY;

namespace BLL.BCY
{
    public class locationManager
    {
        public static IQueryable QueryLocation()
        {
            return locationService.QueryLocation();
        }
    }
}
