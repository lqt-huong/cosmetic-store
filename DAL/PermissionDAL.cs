using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace DAL
{
    public class PermissionDAL
    {
        DatabaseConnection dataServices = new DatabaseConnection();
        DataTable dataTable;

        public PermissionDAL()
        {
        }

        public List<Permission> GetAll()
        {
            List<Permission> list = new List<Permission>();
            string sql = "SELECT * FROM Permission WHERE IsDeleted = false";
            if (!dataServices.OpenDB()) return null;
            dataTable = dataServices.RunQuery(sql);
            Permission quyen;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                quyen = new Permission();
                quyen.PermissionID = (int)dataTable.Rows[i]["PermissionID"];
                quyen.PermissionName = dataTable.Rows[i]["PermissionName"].ToString();
                list.Add(quyen);
            }

            return list;
        }

        public bool Insert(Permission quyen)
        {
            string sql = "SELECT * FROM quyen";
            dataTable = dataServices.RunQuery(sql);
            DataRow row = dataTable.NewRow();
            row["PermissionID"] = quyen.PermissionID;
            row["PermissionName"] = quyen.PermissionName;
            dataTable.Rows.Add(row);
            dataServices.Update(dataTable);
            return true;

        }

        public bool Delete(int maQuyen)
        {
            string sql = "SELECT * FROM PermissionGranting";
            dataTable = dataServices.RunQuery(sql);
            foreach (DataRow row in dataTable.Rows)
            {
                if (row["PermissionID"].Equals(maQuyen))
                    row.Delete();
            }
            dataServices.Update(dataTable);

            sql = $"UPDATE Permission SET IsDeleted = true WHERE PermissionID = '{maQuyen}'";
            dataServices.ExecuteNonQuery(sql);
            return true;
        }

        public bool Update(Permission quyen)
        {
            string sql = "SELECT * FROM quyen";
            dataTable = dataServices.RunQuery(sql);
            dataTable.PrimaryKey = new DataColumn[] { dataTable.Columns["PermissionID"] };
            DataRow row = dataTable.Rows.Find(quyen.PermissionID);
            row["PermissionID"] = quyen.PermissionID;
            row["PermissionName"] = quyen.PermissionName;
            dataServices.Update(dataTable);
            return true;
        }

        public bool TrungMa(int maQuyen)
        {
            string sql = $"SELECT * FROM Permission WHERE PermissionID = {maQuyen}";
            dataTable = dataServices.RunQuery(sql);
            if (dataTable.Rows.Count == 0) return false;
            return true;
        }

        public int NextID()
        {
            string sql = "SELECT MAX(PermissionID) as 'max' FROM Permission";
            dataTable = dataServices.RunQuery(sql);
            int num = -1;
            if (!int.TryParse(dataTable.Rows[0]["max"].ToString(), out num)) return 1;
            int curId = (int)dataTable.Rows[0]["max"];
            return curId + 1;
        }
    }
}
