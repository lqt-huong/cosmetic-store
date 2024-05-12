using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace BLL
{
	public class CTHoaDonNhapBLL
	{
		static CTHoaDonNhapDAL cthdndal;
		static List<CTHoaDonNhap> list;

		public CTHoaDonNhapBLL() {
			cthdndal = new CTHoaDonNhapDAL();
			list = cthdndal.GetAllCTHoaDonNhap();
		}

		public List<CTHoaDonNhap> GetAllCTHoaDonNhap()
		{
			return cthdndal.GetAllCTHoaDonNhap();
		}

		public List<CTHoaDonNhap> GetCTHoaDonNhap(int maHDN)
		{
			return cthdndal.GetCTHoaDonNhap(maHDN);
		}

		public void TangSL(int mhd)
		{
			cthdndal.TangSL(mhd);
		}

		public int AutoID()
		{
			return cthdndal.AutoID();
		}

		public bool KiemTraTrung(int maHDN, int maDSP)
		{
			return cthdndal.KiemTraTrung(maHDN, maDSP);
		}

		public int TongTienPN(int maHDN)
		{
			return cthdndal.TongTien(maHDN);
		}

		public string Them(CTHoaDonNhap cthdnhap)
		{
			if (cthdndal.ThemCTHoaDonNhap(cthdnhap))
			{
				list = cthdndal.GetAllCTHoaDonNhap();
				return "Them thanh cong";
			}
			return "Da co loi xay ra!";
		}

		public string Xoa(int importBillID, int varietyID)
		{
			if (cthdndal.XoaCTHoaDonNhap(importBillID, varietyID))
			{
				list = cthdndal.GetAllCTHoaDonNhap();
				return "Xóa thành công!";
			}
			return "Đã có lỗi xảy ra!";
		}

		public string HuyHDN(int importBillID)
		{
			if (cthdndal.HuyHDN(importBillID))
			{
				list = cthdndal.GetAllCTHoaDonNhap();
				return "Hủy thành công!";
			}
			return "Đã có lỗi xảy ra!";
		}


		public string Sua(CTHoaDonNhap cthdn)
		{
			if (cthdndal.SuaCTHoaDonNhap(cthdn))
			{
				list = cthdndal.GetAllCTHoaDonNhap();
				return "Cập nhật thành công!";
			}
			return "Đã có lỗi xảy ra!";
		}

		public string GetProviderName(int providerID)
		{
			return cthdndal.getProviderName(providerID);
		}

		public string GetStaffName(int staffID)
		{
			return cthdndal.getStaffName(staffID);
		}
	}
}
