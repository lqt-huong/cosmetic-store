using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace DAL
{
    class FunctionDAL
    {
        DatabaseConnection dataServices = new DatabaseConnection();
        DataTable dataTable;

        public FunctionDAL()
        {

        }

        public List<Function> getAll()
        {
            List<Function> list = new List<Function>();
            string sql = "SELECT * FROM Function WHERE IsDeleted = false";
            if (!dataServices.OpenDB()) return null;
            dataTable = dataServices.RunQuery(sql);
            Function chucNang;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                chucNang = new Function();
                chucNang.FunctionID = (int)dataTable.Rows[i]["FunctionID"];
                chucNang.FunctionName = dataTable.Rows[i]["FunctionName"].ToString();
                list.Add(chucNang);
            }

            return list;
        }

        public List<Function> getChucNang(int maQuyen)
        {
            List<Function> list = new List<Function>();
            string sql = $"SELECT cn.FunctionID, cn.FunctionName FROM Function cn, PermissionGranting q WHERE q.FunctionID = cn.FunctionID AND q.PermissionID = {maQuyen}";
            dataTable = dataServices.RunQuery(sql);
            Function chucNang;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                chucNang = new Function();
                chucNang.FunctionID = (int)dataTable.Rows[i]["FunctionID"];
                chucNang.FunctionName = dataTable.Rows[i]["FunctionName"].ToString();
                list.Add(chucNang);
            }

            return list;
        }

        public bool Insert(Function chucNang)
        {
            string sql = "SELECT * FROM Function";
            dataTable = dataServices.RunQuery(sql);
            DataRow row = dataTable.NewRow();
            row["FunctionID"] = chucNang.FunctionID;
            row["PermissionName"] = chucNang.FunctionName;
            dataTable.Rows.Add(row);
            dataServices.Update(dataTable);
            return true;

        }

        public bool Update(Function chucNang)
        {
            string sql = "SELECT * FROM Function";
            dataTable = dataServices.RunQuery(sql);
            dataTable.PrimaryKey = new DataColumn[] { dataTable.Columns["FunctionID"] };
            DataRow row = dataTable.Rows.Find(chucNang.FunctionID);
            row["PermissionID"] = chucNang.FunctionID;
            row["PermissionName"] = chucNang.FunctionName;
            dataServices.Update(dataTable);
            return true;
        }

        public bool Delete(int chucNang)
        {
            string sql = "SELECT * FROM PermissionGranting";
            dataTable = dataServices.RunQuery(sql);
            foreach (DataRow row in dataTable.Rows)
            {
                if (row["FunctionID"].Equals(chucNang))
                    row.Delete();
            }
            dataServices.Update(dataTable);

            sql = $"UPDATE Function SET IsDeleted = true WHERE FunctionID = '{chucNang}'";
            dataServices.ExecuteNonQuery(sql);
            return true;
        }
    }
}
