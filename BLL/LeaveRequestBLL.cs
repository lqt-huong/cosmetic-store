using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;
using DAL;
namespace BLL
{
    public class LeaveRequestBLL
    {
        static LeaveRequestDAL requestDAL;
        static List<LeaveRequest> requestList;
        public LeaveRequestBLL()
        {
            requestDAL = new LeaveRequestDAL();
            requestList = requestDAL.GetAllLeaveRequests();
        }
        public List<LeaveRequest> GetAllLeaveRequests()
        {
            return requestDAL.GetAllLeaveRequests();
        }
        public bool InsertLeaveRequest(LeaveRequest request)
        {
            return requestDAL.InsertLeaveRequest(request);
        }
        public int AutoID()
        {
            return requestDAL.AutoID();
        }
        public bool CheckRequestIDExist(int requestID)
        {
            return requestDAL.CheckRequestIDExist(requestID);
        }
        public bool UpdateLeaveRequest(int requestID, int status)
        {
            return requestDAL.UpdateLeaveRequest(requestID, status);
        }
    }
}
