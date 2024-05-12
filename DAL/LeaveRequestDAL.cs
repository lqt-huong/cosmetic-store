using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ValueObject;
namespace DAL
{
    public class LeaveRequestDAL
    {
        DatabaseConnection dbConn = new DatabaseConnection();
        DataTable dataTable;
        public LeaveRequestDAL()
        {

        }
        public List<LeaveRequest> GetAllLeaveRequests()
        {
            List<LeaveRequest> list = new List<LeaveRequest>();
            string query = "SELECT * FROM LeaveRequest";
            if (!dbConn.OpenDB())
                return null;
            dataTable = dbConn.RunQuery(query);
            LeaveRequest leaveRequest;
            foreach (DataRow row in dataTable.Rows)
            {
                leaveRequest = new LeaveRequest();
                leaveRequest.RequestID = (int)row["RequestID"];
                leaveRequest.ApproveStatus = (int)row["ApproveStatus"];
                leaveRequest.RequestContent = row["RequestContent"].ToString();
                leaveRequest.LeavingDate = Convert.ToDateTime(row["LeavingDate"]);
                leaveRequest.LeavingDays = (int)row["LeavingDays"];
                leaveRequest.LeavingType = (int)row["LeavingType"];
                leaveRequest.StaffID = (int)row["StaffID"];
                list.Add(leaveRequest);
            }
            return list;
        }
        public bool InsertLeaveRequest(LeaveRequest request)
        {
            string query = "SELECT * FROM LeaveRequest";
            dataTable = dbConn.RunQuery(query);
            DataRow new_row = dataTable.NewRow();
            new_row["RequestID"] = request.RequestID;
            new_row["ApproveStatus"] = request.ApproveStatus;
            new_row["RequestContent"] = request.RequestContent;
            new_row["LeavingDate"] = request.LeavingDate;
            new_row["LeavingDays"] = request.LeavingDays;
            new_row["LeavingType"] = request.LeavingType;
            new_row["StaffID"] = request.StaffID;

            dataTable.Rows.Add(new_row);
            dbConn.Update(dataTable);
            return true;
        }
        public bool UpdateLeaveRequest(int requestID, int status)
        {
            string query = "SELECT * FROM LeaveRequest";
            dataTable = dbConn.RunQuery(query);
            dataTable.PrimaryKey = new DataColumn[] { dataTable.Columns["RequestID"] };
            DataRow new_row = dataTable.Rows.Find(requestID);
            new_row["ApproveStatus"] = status;
            dbConn.Update(dataTable);
            return true;
        }
        public int AutoID()
        {
            int id = 0;
            string query = "SELECT MAX(RequestID) as max_requestID FROM LeaveRequest";
            dataTable = dbConn.RunQuery(query);
            int num = -1;
            if (!int.TryParse(dataTable.Rows[0]["max_requestID"].ToString(), out num))
                return 1;
            id = (int)dataTable.Rows[0]["max_requestID"];
            return id + 1;
        }
        public bool CheckRequestIDExist(int requestID)
        {
            string query = $"SELECT * FROM LeaveRequest WHERE RequestID={requestID}";
            dataTable = dbConn.RunQuery(query);
            if (dataTable.Rows.Count > 0) 
                return true;
            return false;
        }

    }
}
