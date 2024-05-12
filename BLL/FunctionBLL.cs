using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace BLL
{
    public class FunctionBLL
    {
        FunctionDAL dal = new FunctionDAL();
        List<Function> list = new List<Function>();

        public FunctionBLL()
        {
        }

        public List<Function> GetAll()
        {
            return dal.GetAll();
        }

        public List<Function> GetChucNang(int maQuyen)
        {
            return dal.GetChucNang(maQuyen);
        }

        public string Insert(Function chucNang)
        {
            if (dal.Insert(chucNang))
            {
                return "Thêm thành công!";
            }
            else
            {
                return "Đã có lỗi xảy ra!";
            }
        }

        public string Update(Function chucNang)
        {
            if (dal.Update(chucNang))
            {
                return "Cập nhật thành công!";
            }
            else
            {
                return "Đã có lỗi xảy ra!";
            }
        }

        public string Delete(int chucNang)
        {
            if (dal.Delete(chucNang))
            {
                return "Xóa thành công!";
            }
            else
            {
                return "Đã có lỗi xảy ra!";
            }
        }

        public string GetTenCN(int maCN)
        {
            return dal.GetTenCN(maCN);
        }
    }
}
