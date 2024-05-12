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

        public string Insert(BillDetails bd)
        {
            if (dao.Insert(bd))
            {
                return "Thêm thành công!";
            }
            return "Đã có lỗi xảy ra";
        }

        public string Delete(int BillID, int VarietyID)
        {
            if (dao.Delete(BillID, VarietyID))
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

        public bool TrungMa(int BillID, int VarietyID)
        {
            return dao.TrungMa(BillID, VarietyID);
        }
    }
}
