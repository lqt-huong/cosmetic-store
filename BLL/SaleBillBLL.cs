using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace BLL
{
    public class SaleBillBLL
    {
        static SaleBillDAL dao;
        static List<SaleBill> danhSach;

        public SaleBillBLL()
        {
            dao = new SaleBillDAL();
            danhSach = dao.getAll();
        }

        public List<SaleBill> getAll()
        {
            return dao.getAll();
        }

        public int NextID()
        {
            return dao.NextID();
        }

        public int GetFee(int VarietyID)
        {
            return dao.GetFee(VarietyID);
        }

        public string Insert(SaleBill saleBill)
        {

            saleBill.IsDeleted = false;

            if (dao.Insert(saleBill))
            {
                danhSach = dao.getAll();
                return "Thêm thành công!";
            }
            return "Đã có lỗi xảy ra!";
        }

        public string Delete(int BillID, int StaffID)
        {
            if (dao.Delete(BillID, StaffID))
            {
                danhSach = dao.getAll();
                return "Xóa thành công!";
            }
            return "Đã có lỗi xảy ra";
        }

        public string Update(SaleBill saleBill)
        {
            if (dao.Update(saleBill))
            {
                danhSach = dao.getAll();
                return "Cập nhật thành công!";
            }
            return "Đã có lỗi xảy ra!";
        }

        public bool TrungMa(int BillID)
        {
            return dao.TrungMa(BillID);
        }

        public bool TrungVarietyID(int VarietyID, int StaffID)
        {
            return dao.TrungVarietyID(VarietyID, StaffID);
        }

/*        public List<SaleBill> SearchStateless(String key, int option, DateTime date)
        {
            List<SaleBill> searchList = new List<SaleBill>();
            if (option == 0)
            {
                foreach (SaleBill hd in danhSach)
                {
                    if (hd.StaffID == Convert.ToInt32(key))
                    {
                        searchList.Add(hd);
                    }
                }
            }
            else
            {
                foreach (SaleBill hd in danhSach)
                {
                    if (hd.NgayHD.Date.CompareTo(date.Date) == 0)
                    {
                        searchList.Add(hd);
                    }
                }
            }
            return searchList;
        }
        public List<SaleBill> Search(string key, int option, DateTime date, bool state)
        {
            List<SaleBill> searchList = new List<SaleBill>();

            if (option == 0) //tim bang ma hoa don
            {
                if (state == false)
                {
                    foreach (SaleBill hd in danhSach)
                    {
                        if (hd.StaffID == Convert.ToInt32(key) && hd.IsDeleted == false)
                        {
                            searchList.Add(hd);
                        }
                    }
                }
                else if (state == true)
                {
                    foreach (SaleBill hd in danhSach)
                    {
                        if (hd.StaffID == Convert.ToInt32(key) && hd.IsDeleted == true)
                        {
                            searchList.Add(hd);
                        }
                    }
                }
                else
                {
                    foreach (SaleBill hd in danhSach)
                    {
                        if (hd.StaffID == Convert.ToInt32(key))
                        {
                            searchList.Add(hd);
                        }
                    }
                }
            }
            else  //tim theo ngay
            {
                if (state == false)
                {
                    foreach (SaleBill hd in danhSach)
                    {
                        if (hd.NgayHD.Date.CompareTo(date.Date) == 0 && hd.IsDeleted == false)
                        {
                            searchList.Add(hd);
                        }
                    }
                }
                else if (state == true)
                {
                    foreach (SaleBill hd in danhSach)
                    {
                        if (hd.NgayHD.Date.CompareTo(date.Date) == 0 && hd.IsDeleted == true)
                        {
                            searchList.Add(hd);
                        }
                    }
                }
                else
                {
                    foreach (SaleBill hd in danhSach)
                    {
                        if (hd.NgayHD.Date.CompareTo(date.Date) == 0)
                        {
                            searchList.Add(hd);
                        }
                    }
                }
            }

            return searchList;
        }*/
    }
}
