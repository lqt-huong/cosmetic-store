using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThongKeDoanhThuDAL
    {
        DataServices dataServices = new DataServices();
        DataTable dataTable;

        public ThongKeDoanhThuDAL()
        {
            dataServices.OpenDB();
        }

        public DataTable GetThongKeDoanhThu()
        {
            string sql = "SELECT p.ProductID AS 'Mã sản phẩm', p.ProductName AS 'Tên sản phẩm', c.CategoryName AS 'Loại', pv.Volume AS 'Dung tích (g)', pv.Price AS 'Giá', bd.Quantity AS 'Số lượng', sb.Date AS 'Ngày' " +
                                                "FROM Product p " +
                                                "JOIN Category c ON p.CategoryID = c.CategoryID " +
                                                "JOIN ProductVariety pv ON pv.ProductID = p.ProductID " +
                                                "JOIN BillDetails bd ON bd.VarietyID = pv.VarietyID " +
                                                "JOIN SaleBill sb ON sb.BillID = bd.BillID " +
                                                "WHERE sb.isDeleted = 0 " +
                                                "GROUP BY p.ProductID, p.ProductName, c.CategoryName, pv.Volume, pv.Price, bd.Quantity, sb.Date " +
                                                "ORDER BY sb.Date";
            if (!dataServices.OpenDB()) return null;
            dataTable = dataServices.RunQuery(sql);
            return dataTable;
        }
    }
}
