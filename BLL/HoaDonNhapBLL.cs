using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace BLL
{
	public class HoaDonNhapBLL
	{
		static HoaDonNhapDAL hdndal;
		static List<HoaDonNhap> list;

		public HoaDonNhapBLL()
		{
			hdndal = new HoaDonNhapDAL();
			list = hdndal.getAllImportBill();
		}

		public List<HoaDonNhap> GetAllImportBill()
		{
			return hdndal.getAllImportBill();
		}

		public int AutoID()
		{
			return hdndal.AutoID();
		}

		public string Them(HoaDonNhap hdnhap)
		{
			hdnhap.ImportBillID = AutoID();
			if (hdndal.ThemHDNhap(hdnhap))
			{
				list = hdndal.getAllImportBill();
				return "Them thanh cong";
			}
			return "Da co loi xay ra!";
		}

		public string GetProviderName(int providerID)
		{
			return hdndal.getProviderName(providerID);
		}

		public string GetStaffName(int staffID)
		{
			return hdndal.getStaffName(staffID);
		}
	}
}
