using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using ValueObject;

namespace BLL
{
    public class StaffBLL
    {
        static StaffDAL staffDAL;
        static List<Staff> staffList;
        static QLNS_ThongKe tk = new QLNS_ThongKe();
        public StaffBLL()
        {
            staffDAL = new StaffDAL();
            staffList = staffDAL.GetAllStaffs();
        }

        public List<Staff> GetAllStaff()
        {
            return staffDAL.GetAllStaffs();
        }
        public bool InsertStaff(Staff staff)
        {
            return staffDAL.InsertStaff(staff);
        }
        public int AutoID()
        {
            return staffDAL.AutoID();
        }
        public bool CheckStaffIDExist(int staffID)
        {
            return staffDAL.CheckStaffIDExist(staffID);
        }
        public List<Staff> SearchStaff(String key, int filter)
        {
            List<Staff> list = new List<Staff>();
            if(filter == 0)
            {
                foreach (Staff staff in staffList)
                {
                    if(staff.StaffID == Convert.ToInt32(key))
                    {
                        list.Add(staff);
                    }
                }
            }
            else if(filter == 1)
            {
                foreach (Staff staff in staffList)
                {
                    if(staff.FullName.ToLower().Contains(key.ToLower()))
                    {
                        list.Add(staff);
                    }
                }
            }
            return list;
        }
        public bool DeleteStaff(int staffID)
        {
            if(staffDAL.DeleteStaff(staffID))
            {
                staffList = staffDAL.GetAllStaffs();
                return true;
            }
            return false;
        }

        public bool UpdateStaff(Staff staff)
        {
            return staffDAL.UpdateStaff(staff);
        }
        public DataTable ThongKeNhanVienTheoCV()
        {
            return tk.ThongKeNhanVienTheoCV();
        }

    }
}
