using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace DAL
{
    public class PermissionGrantingDAL
    {
        DatabaseConnection dataServices = new DatabaseConnection();
        DataTable dataTable;

        public PermissionGrantingDAL()
        {
            dataServices.OpenDB();
        }

        public List<PermissionGranting> QuyenTK(string tenTK)
        {
            List<PermissionGranting> dsQuyen = new List<PermissionGranting>();
            string sql = $"SELECT ct.PermissionID, ct.FunctionID FROM PermissionGranting ct, Account tk WHERE tk.PermissionID = ct.PermissionID AND tk.Username = '{tenTK}'";
            if (!dataServices.OpenDB()) return null;
            dataTable = dataServices.RunQuery(sql);
            PermissionGranting chiTietPhanQuyen;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                chiTietPhanQuyen = new PermissionGranting();
                chiTietPhanQuyen.PermissionID = (int)dataTable.Rows[i]["PermissionID"];
                chiTietPhanQuyen.FunctionID = (int)dataTable.Rows[i]["FunctionID"];
                dsQuyen.Add(chiTietPhanQuyen);
            }

            return dsQuyen;
        }

        public List<PermissionGranting> GetCTPhanQuyen(int maQuyen)
        {
            List<PermissionGranting> dsQuyen = new List<PermissionGranting>();
            string sql = $"SELECT ct.PermissionID, ct.FunctionID FROM PermissionGranting ct WHERE ct.PermissionID = '{maQuyen}'";
            if (!dataServices.OpenDB()) return null;
            dataTable = dataServices.RunQuery(sql);
            PermissionGranting chiTietPhanQuyen;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                chiTietPhanQuyen = new PermissionGranting();
                chiTietPhanQuyen.PermissionID = (int)dataTable.Rows[i]["PermissionID"];
                chiTietPhanQuyen.FunctionID = (int)dataTable.Rows[i]["FunctionID"];
                dsQuyen.Add(chiTietPhanQuyen);
            }

            return dsQuyen;
        }

        public bool Insert(PermissionGranting quyen)
        {
            string sql = $"INSERT INTO PermissionGranting(PermissionID, FunctionID) VALUES ({quyen.PermissionID}, {quyen.FunctionID})";
            try
            {
                dataServices.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool Delete(PermissionGranting quyen)
        {
            string sql = $"DELETE FROM PermissionGranting WHERE PermissionID = {quyen.PermissionID} AND FunctionID = {quyen.FunctionID}";
            try
            {
                dataServices.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool TrungMa(PermissionGranting quyen)
        {
            string sql = $"SELECT * FROM PermissionGranting WHERE PermissionID = {quyen.PermissionID} AND FunctionID={quyen.FunctionID}";
            dataTable = dataServices.RunQuery(sql);
            if (dataTable.Rows.Count == 0) return false;
            return true;
        }
    }

}
