using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThongKeDoanhThuBLL
    {
        static ThongKeDoanhThuDAL dao;

        public ThongKeDoanhThuBLL()
        {
            dao = new ThongKeDoanhThuDAL();
        }

        public DataTable GetThongKeDoanhThu()
        {
            return dao.GetThongKeDoanhThu();
        }
    }
}
