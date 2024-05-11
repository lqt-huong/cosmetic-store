using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ValueObject;
namespace DAL
{
    public class StaffDAL
    {
        DatabaseConnection dbConn = new DatabaseConnection();
        DataTable dataTable;
        public StaffDAL()
        {

        }

        public List<Staff> GetAllStaffs()
        {
               List<Staff> list = new List<Staff>();
               string query = "SELECT * FROM Staff WHERE IsDeleted=0";
            if (!dbConn.OpenDB())
                return null;
            dataTable = dbConn.RunQuery(query);
                Staff staff;
                foreach (DataRow row in dataTable.Rows)
                {
                    staff = new Staff();
                    staff.StaffID = (int)row["StaffID"];
                    staff.FullName = row["FullName"].ToString();
                    staff.DOB = Convert.ToDateTime(row["DoB"]);
                    staff.Address = row["Address"].ToString();
                    staff.IsDeleted = Convert.ToBoolean(row["IsDeleted"]);
                    list.Add(staff);
                }
                return list;
        }

        public bool InsertStaff(Staff staff )
        {
            string query = "SELECT * FROM Staff";
            dataTable = dbConn.RunQuery(query);
            DataRow new_row = dataTable.NewRow();
            new_row["StaffID"] = staff.StaffID;
            new_row["FullName"] = staff.FullName;
            new_row["DoB"] = staff.DOB;
            new_row["Address"] = staff.Address;
            new_row["IsDeleted"] = staff.IsDeleted ? 1: 0;
            dataTable.Rows.Add(new_row);
            dbConn.Update(dataTable);
            return true;
        }
        public bool UpdateStaff(Staff staff)
        {
            string query = "SELECT * FROM Staff";
            dataTable = dbConn.RunQuery(query);
            dataTable.PrimaryKey = new DataColumn[] { dataTable.Columns["StaffID"] };
            DataRow new_row = dataTable.Rows.Find(staff.StaffID);
            new_row["FullName"] = staff.FullName;
            new_row["DoB"] = staff.DOB;
            new_row["Address"] = staff.Address; 
            new_row["IsDeleted"] = staff.IsDeleted ? 1: 0;
            dbConn.Update(dataTable);
            return true;
        }
        public int AutoID()
        {
            int id = 0;
            string query = "SELECT MAX(StaffID) as max_staffID FROM Staff";
            dataTable = dbConn.RunQuery(query);
            int num = -1;
            if (!int.TryParse(dataTable.Rows[0]["max_staffID"].ToString(), out num))
                return 1;
            id = (int)dataTable.Rows[0]["max_staffID"];
            return id + 1;
        }
        
        public bool CheckStaffIDExist(int staffID)
        {
            string query = $"SELECT * FROM Staff WHERE StaffID={staffID}";
            dataTable = dbConn.RunQuery(query);
            if (dataTable.Rows.Count > 0) return true; 
            return false;
        }

        

        public bool DeleteStaff(int staffID)
        {
            try
            {
                string query = $"UPDATE Staff SET IsDeleted = true WHERE StaffID={staffID}";
                dbConn.ExecuteNonQuery(query);
                dbConn.Update(dataTable);
            }catch (Exception ex) { return false; }
            return true;
        }
    }
}
