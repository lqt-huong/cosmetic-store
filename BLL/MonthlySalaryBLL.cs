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
    }
}
