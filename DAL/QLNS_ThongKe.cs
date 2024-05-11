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
            String query = $"SELECT P.PositionName AS PositionName," +
                $"COUNT(S.StaffID) AS NumberOfEmployees," +
                $"Sum(P.Salary) AS TotalSalary" +
                $"FROM  Position P" +
                $"JOIN Contract C ON P.PositionID = C.PositionID" +
                $"JOIN  Staff S On C.StaffID = S.StaffID" +
                $"GROUP BY P.PosName";
            dbConn.OpenDB();
            dataTable = dbConn.RunQuery(query);
            return dataTable;
        }
    }
}
