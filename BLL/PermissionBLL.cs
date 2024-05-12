using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace BLL
{
    public class PermissionBLL
    {
        PermissionDAL dal = new PermissionDAL();
        List<Permission> list = new List<Permission>();

        public List<Permission> GetAll()
        {
            return dal.GetAll();
        }

        public string Insert(Permission quyen)
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

        public string Update(Permission quyen)
        {
            if (dal.Update(quyen))
            {
                return "Cập nhật thành công!";
            }
            else
            {
                return "Đã có lỗi xảy ra!";
            }
        }

        public string Delete(int maQuyen)
        {
            if (dal.Delete(maQuyen))
            {
                return "Xóa thành công!";
            }
            else
            {
                return "Đã có lỗi xảy ra!";
            }
        }

        public bool TrungMa(int maQuyen)
        {
            return dal.TrungMa(maQuyen);
        }

        public int NextID()
        {
            return dal.NextID();
        }

        public string GetTenQuyen(int maQuyen)
        {
            return dal.GetTenQuyen(maQuyen);
        }
    }
}
