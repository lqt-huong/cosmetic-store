using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace BLL
{
	public class ProductDetailBLL
	{
		static ThongTinSanPhamDAL spdal;
		static List<TTCTSanPham> listSp;
		static List<ProductVariety> listVariety;

		public ProductDetailBLL()
		{
			spdal = new ThongTinSanPhamDAL();
			listSp = spdal.GetAllTTSanPhams();
			listVariety = spdal.GetAllProductVariety();
		}

		public List<TTCTSanPham> GetAllTTSanPhams()
		{
			return spdal.GetAllTTSanPhams();
		}

		public List<ProductVariety> GetAllProductVariety()
		{
			return spdal.GetAllProductVariety();
		}

		public List<ProductVariety> GetSanPhamNCC(int providerID)
		{
			return spdal.GetSanPhamNCC(providerID);
		}


		public int AutoID()
		{
			return spdal.AutoID(); 
		}

		public bool KiemTraTrung(int productID, int productVolume)
		{
			return spdal.KiemTraTrung(productID, productVolume);
		}

		public bool KiemTraTrungMa(int varietyID)
		{
			return spdal.KiemTraTrungMa(varietyID);
		}

		public string Them(ProductVariety tTSanPham)
		{
			tTSanPham.VarietyID = AutoID();
			if (spdal.ThemTTSP(tTSanPham))
			{
				listVariety = spdal.GetAllProductVariety();
				return "Them thanh cong";
			}
			return "Da co loi xay ra!";
		}

		public string Xoa(int varietyID)
		{
			if (spdal.XoaTTSP(varietyID))
			{
				listVariety = spdal.GetAllProductVariety();
				return "Xóa thành công!";
			}
			return "Đã có lỗi xảy ra!";
		}

		public string Sua(ProductVariety tTSanPham)
		{
			if (spdal.SuaTTSP(tTSanPham))
			{
				listVariety = spdal.GetAllProductVariety();
				return "Cập nhật thành công!";
			}
			return "Đã có lỗi xảy ra!";
		}

		public string GetProductName(int productID)
		{
			return spdal.getProductName(productID);
		}

		public string GetProviderName(int providerID)
		{
			return spdal.getProviderName(providerID);
		}

		public string getCategoryName(int categoryID)
		{
			return spdal.getCategoryName(categoryID);
		}
	}

}
