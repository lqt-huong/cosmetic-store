using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace BLL
{
    public class BillDetailsBLL
    {
        static BillDetailsDAL dao;
        static List<BillDetails> danhSach;


        public BillDetailsBLL()
        {
            dao = new BillDetailsDAL();
        }

        public List<BillDetails> getAll(int maHD)
        {
            return dao.getAll(maHD);
        }

        public void Insert(BillDetails bd, int nhomKH, int maHV)
        {
            bd.BillID = NextID();
            bd.Quantity = 
            bd.Price = GetFee(bd.VarietyID);
            if (dao.Insert(bd))
            {
            }
        }

        public string Delete(int BillID)
        {
            if (dao.Delete(BillID))
            {
                return "Xóa thành công!";
            }
            return "Đã có lỗi xảy ra";
        }

        public string Update(BillDetails bd)
        {
            if (dao.Update(bd))
            {
                return "Cập nhật thành công!";
            }
            return "Đã có lỗi xảy ra!";
        }

        public int GetFee(int VarietyID)
        {
            return dao.GetFee(VarietyID);
        }

        public int NextID()
        {
            return dao.NextID();
        }
    }
}
