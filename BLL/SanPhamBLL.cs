using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace BLL
{
	public class SanPhamBLL
	{
		static SanPhamDAL spdal;
		static List<SanPham> list;

		public SanPhamBLL()
		{
			spdal = new SanPhamDAL();
			list = spdal.GetAllSP();
		}

		public List<SanPham> GetAllSP()
		{
			return spdal.GetAllSP();
		}

		public int AutoID()
		{
			return spdal.AutoID();
		}

		public string Them(SanPham sanPham)
		{
			sanPham.ProductID = AutoID();
			if (spdal.ThemSP(sanPham))
			{
				list = spdal.GetAllSP();
				return "Them thanh cong";
			}
			return "Da co loi xay ra!";
		}

		public string Xoa(int productID)
		{
			if (spdal.XoaSP(productID))
			{
				list = spdal.GetAllSP();
				return "Xóa thành công!";
			}
			return "Đã có lỗi xảy ra!";
		}

		public string Sua(SanPham sanPham)
		{
			if (spdal.SuaSP(sanPham))
			{
				list = spdal.GetAllSP();
				return "Cập nhật thành công!";
			}
			return "Đã có lỗi xảy ra!";
		}

		public bool KiemTraTrung(int productID)
		{
			return spdal.KiemTraTrung(productID);
		}

		public string GetProviderName(int providerID)
		{
			return spdal.getProviderName(providerID);
		}

		public string GetCategoryName(int categoryID)
		{
			return spdal.getCategoryName(categoryID);
		}

	}
}
