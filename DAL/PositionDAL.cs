using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ValueObject;

namespace DAL
{
    public class PositionDAL
    {
        DatabaseConnection dbConn = new DatabaseConnection();
        DataTable dataTable;
        public PositionDAL()
        {

        }

        public List<Position> GetAllPositions()
        {
            List<Position> list = new List<Position>();
            string query = "SELECT * FROM Position WHERE IsDeleted=0";
            if (!dbConn.OpenDB())
                return null;
            dataTable = dbConn.RunQuery(query);
            Position position;
            foreach (DataRow row in dataTable.Rows)
            {
                position = new Position();
                position.PositionID = (int)row["PositionID"];
                position.PositionName = row["PositionName"].ToString();
                position.Salary =(int)row["Salary"];
                position.IsDeleted = Convert.ToByte((bool)row["IsDeleted"]);
                list.Add(position);
            }
            return list;
        }

        public bool InsertPosition(Position pos)
        {
            string query = "SELECT * FROM Position";
            dataTable = dbConn.RunQuery(query);
            DataRow new_row = dataTable.NewRow();
            new_row["PositionID"] = pos.PositionID;
            new_row["PositionName"] = pos.PositionName;
            new_row["Salary"] = pos.Salary;
            new_row["IsDeleted"] = pos.IsDeleted;
            dataTable.Rows.Add(new_row);
            dbConn.Update(dataTable);
            return true;
        }

        public int AutoID()
        {
            int id = 0;
            string query = "SELECT MAX(PositionID) as max_posID FROM Position";
            dataTable = dbConn.RunQuery(query);
            int num = -1;
            if (!int.TryParse(dataTable.Rows[0]["max_posID"].ToString(), out num))
                return 1;
            id = (int)dataTable.Rows[0]["max_posID"];
            return id + 1;
        }

        public bool CheckPositionIDExist(int pos)
        {
            string query = $"SELECT * FROM Position WHERE PositionID={pos}";
            dataTable = dbConn.RunQuery(query);
            if (dataTable.Rows.Count > 0) return true;
            return false;
        }

        public bool UpdatePosition(Position pos)
        {
            string query = "SELECT * FROM Position";
            dataTable = dbConn.RunQuery(query);
            dataTable.PrimaryKey = new DataColumn[] { dataTable.Columns["PositionID"] };
            DataRow new_row = dataTable.Rows.Find(pos.PositionID);
            new_row["PositionName"] = pos.PositionName;
            new_row["Salary"] = pos.Salary;
            new_row["IsDeleted"] = pos.IsDeleted;
            dbConn.Update(dataTable);
            return true;
        }

        public bool DeletePostion(int posID)
        {
            try
            {
                string query = $"DELETE FROM Position WHERE PositionID={posID}";
                dbConn.ExecuteNonQuery(query);
            }
            catch (Exception ex) { return false; }
            return true;
        }
    }
}

