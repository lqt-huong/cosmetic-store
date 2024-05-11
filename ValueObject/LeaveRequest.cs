using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class LeaveRequest
    {
        private int requestID;
        private int approveStatus;
        private string requestContent;
        private DateTime leavingDate;
        private int leavingDays;
        private int leavingType;
        private int staffID;

        public LeaveRequest()
        {

        }
        public LeaveRequest(int id, int status, string content, DateTime date, int days,int type, int staffid)
        {
            requestID = id;
            approveStatus = status;
            requestContent = content;
            leavingDate = date;
            leavingDays = days;
            leavingType = type;
            staffID = staffid;
        }
        public int RequestID { get { return this.requestID; } set { this.requestID = value; } }
        public int AppproveStatus { get { return this.approveStatus; } set { this.approveStatus = value; } }

        public string RequestContent { get { return this.requestContent; } set { this.requestContent = value; } }
        public DateTime LeavingDate { get { return this.leavingDate; } set { this.leavingDate = value; } }
        public int LeavingDays { get { return this.leavingDays; } set { this.leavingDays = value; } }
        public int LeavingType { get { return this.leavingType; } set { this.leavingType = value; } }
        public int StaffID { get { return this.staffID; } set { this.staffID = value; } }

    }
}
