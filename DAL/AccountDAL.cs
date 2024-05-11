using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace DAL
{
    public class AccountDAL
    {
        DatabaseConnection dataServices = new DatabaseConnection();
        DataTable dataTable;

        public AccountDAL()
        {

        }

        public List<Account> GetAll()
        {
            List<Account> danhSach = new List<Account>();
            string sql = "SELECT * FROM Account WHERE IsDeleted = 0";
            if (!dataServices.OpenDB()) return null;
            dataTable = dataServices.RunQuery(sql);
            Account taiKhoan;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                taiKhoan = new Account();
                taiKhoan.Username = dataTable.Rows[i]["Username"].ToString();
                taiKhoan.Password = dataTable.Rows[i]["Password"].ToString();
                taiKhoan.StaffID = (int)dataTable.Rows[i]["StaffID"];
                taiKhoan.PermissionID = (int)dataTable.Rows[i]["PermissionID"];
                danhSach.Add(taiKhoan);
            }

            return danhSach;
        }

        public Account TimTaiKhoan(string tenTK, string matKhau)
        {
            string sql = $"SELECT * FROM Account WHERE Username = '{tenTK}' AND Password = '{matKhau}'";
            dataTable = dataServices.RunQuery(sql);
            if (dataTable.Rows.Count == 0) return null;
            Account taiKhoan = new Account();
            taiKhoan.Username = dataTable.Rows[0]["Username"].ToString();
            taiKhoan.Password = dataTable.Rows[0]["Password"].ToString();
            taiKhoan.StaffID = (int)dataTable.Rows[0]["StaffID"];
            taiKhoan.PermissionID = (int)dataTable.Rows[0]["PermissionID"];
            return taiKhoan;
        }

        public bool Insert(Account taiKhoan)
        {
            string sql = "SELECT * FROM Account";
            dataTable = dataServices.RunQuery(sql);
            DataRow row = dataTable.NewRow();
            row["Username"] = taiKhoan.Username;
            row["Password"] = taiKhoan.Password;
            row["StaffID"] = taiKhoan.StaffID;
            row["PermissionID"] = taiKhoan.PermissionID;
            dataTable.Rows.Add(row);
            dataServices.Update(dataTable);
            return true;
        }

        public bool Delete(string tenTK)
        {
            try
            {
                string sql = $"UPDATE Account SET IsDeleted = true WHERE Username = '{tenTK}'";
                dataServices.ExecuteNonQuery(sql);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool Update(Account taiKhoan)
        {
            string sql = "SELECT * FROM tai_khoan";
            dataTable = dataServices.RunQuery(sql);
            dataTable.PrimaryKey = new DataColumn[] { dataTable.Columns["Username"] };
            DataRow row = dataTable.Rows.Find(taiKhoan.Username);
            row["Username"] = taiKhoan.Username;
            row["Password"] = taiKhoan.Password;
            row["StaffID"] = taiKhoan.StaffID;
            row["PermissionID"] = taiKhoan.PermissionID;
            dataServices.Update(dataTable);
            return true;
        }

        public bool TrungTenTK(string tenTK)
        {
            string sql = $"SELECT * FROM Account WHERE Username = '{tenTK}'";
            dataTable = dataServices.RunQuery(sql);
            if (dataTable.Rows.Count == 0) return false;
            return true;
        }

        public bool KTMatKhau(string tenTK, string matKhau)
        {
            string sql = $"SELECT * FROM Account WHERE Username = '{tenTK}' AND Password = '{matKhau}'";
            dataTable = dataServices.RunQuery(sql);
            if (dataTable.Rows.Count == 0) return false;
            return true;
        }
    }
}
