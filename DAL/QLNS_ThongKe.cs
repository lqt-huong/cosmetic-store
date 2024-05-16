using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ValueObject;
namespace DAL
{
    public class QLNS_ThongKe
    {
        DatabaseConnection dbConn;
        DataTable dataTable;
        public QLNS_ThongKe()
        {
            dbConn = new DatabaseConnection();
        }
        public DataTable ThongKeNhanVienTheoCV()
        {
            String query = $"SELECT P.PositionName AS PositionName, " +
                $"COUNT(S.StaffID) AS NumberOfEmployees, " +
                $"SUM(M.ActualReceiving) AS TotalSalary " +
                $"FROM Position P " +
                $"JOIN MonthlySalary M ON P.PositionID = M.PositionID " +
                $"JOIN Staff S ON M.StaffID = S.StaffID " +
                $"GROUP BY P.PositionName; ";
            dbConn.OpenDB();
            dataTable = dbConn.RunQuery(query);
            return dataTable;
        }
    }
}
