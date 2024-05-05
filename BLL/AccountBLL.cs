using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ValueObject;

namespace BLL
{
    public class AccountBLL
    {
        AccountDAL dal = new AccountDAL();
        List<Account> list = new List<Account>();

        public List<Account> GetAll()
        {
            return dal.GetAll();
        }

        public string Insert(Account account)
        {
            if (dal.Insert(account))
            {
                return "Thêm thành công!";
            }
            else
            {
                return "Đã có lỗi xảy ra!";
            }
        }

        public string Update(Account accout)
        {
            if (dal.Update(accout))
            {
                return "Cập nhật thành công";
            }
            else
            {
                return "Đã có lỗi xảy ra!";
            }
        }

        public string Delete(string username)
        {
            if (dal.Delete(username))
            {
                return "Xóa thành công!";
            }
            else
            {
                return "Đã có lỗi xảy ra!";
            }
        }

        public Account TimTK(string username, string password)
        {
            return dal.TimTaiKhoan(username, password);
        }

        public bool TrungTenTK(string tenTK)
        {
            return dal.TrungTenTK(tenTK);
        }
    }
}
