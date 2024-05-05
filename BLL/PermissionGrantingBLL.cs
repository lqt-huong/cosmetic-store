using DAL;
using ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PermissionGrantingBLL
    {
        PermissionGrantingDAL dal = new PermissionGrantingDAL();

        public PermissionGrantingBLL()
        {
        }

        public List<PermissionGranting> GetCTPhanQuyen(int maQuyen)
        {
            return dal.GetCTPhanQuyen(maQuyen);
        }

        public List<PermissionGranting> QuyenTK(string tenTK)
        {
            return dal.QuyenTK(tenTK);
        }

        public string Insert(PermissionGranting quyen)
        {
            if (dal.Insert(quyen))
            {
                return "Thêm thành công!";
            }
            else
            {
                return "Đã có lỗi xảy ra!";
            }
        }

        public string Delete(PermissionGranting quyen)
        {
            if (dal.Delete(quyen))
            {
                return "Xóa thành công!";
            }
            else
            {
                return "Đã có lỗi xảy ra!";
            }
        }

        public bool TrungMa(PermissionGranting quyen)
        {
            return dal.TrungMa(quyen);
        }
    }
}
