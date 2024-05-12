using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ValueObject;

namespace BLL
{
    public class MonthlySalaryBLL
    {
        MonthlySalaryDAL dal = new MonthlySalaryDAL();
        LeaveRequestDAL dalLR = new LeaveRequestDAL();

        public MonthlySalaryBLL()
        {
        }

        public List<MonthlySalary> GetAll(int month, int year)
        {
            return dal.GetAll(month, year);
        }

        public bool Insert(MonthlySalary luong)
        {
            return dal.Insert(luong);
        }

        public bool DaTinhLuong(int month, int year)
        {
            return dal.DaTinhLuong(month, year);
        }

        public int tongNgayNghi(int staffID, int month, int year)
        {
            int tongNgayNghi = 0;
            List<LeaveRequest> listLR = dalLR.GetAllLeaveRequests();
            foreach(LeaveRequest lr in listLR)
            {
                if (lr.StaffID == staffID && lr.LeavingDate.Month == month && lr.LeavingDate.Year == year)
                {
                    tongNgayNghi += lr.LeavingDays;
                }
            }
            return tongNgayNghi;
        }

        public int GetSalary(int positionID)
        {
            return dal.GetSalary(positionID);
        }

        public int calcThucNhan(int positionID, int totalLeaving)
        {
            int salary = dal.GetSalary(positionID);
            int leavingMinus = totalLeaving * (Convert.ToInt32(salary/26));
            return salary - leavingMinus;
        }

        public int GetPositionID(int staffID, int month, int year)
        {
            return dal.GetPositionID(staffID, month, year);
        }
    }
}
