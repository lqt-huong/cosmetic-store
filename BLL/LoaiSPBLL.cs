using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace BLL
{
	public class LoaiSPBLL
	{
		static LoaiSPDAL lsp;
		static List<LoaiSP> list;

		public LoaiSPBLL() 
		{
			lsp = new LoaiSPDAL();
			list = lsp.getAllLoaiSP();
		}

		public List<LoaiSP> getAllLoaiSP()
		{
			return lsp.getAllLoaiSP();
		}

		public int AutoID()
		{
			return lsp.AutoID();
		}

		public bool KiemTraTrung(int categoryID)
		{
			return lsp.KiemTraTrung(categoryID);
		}

		public string Them(LoaiSP loaisp)
		{
			loaisp.CategoryID = AutoID();
			if (lsp.ThemLSP(loaisp))
			{
				list = lsp.getAllLoaiSP();
				return "Them thanh cong";
			}
			return "Da co loi xay ra!";
		}

		public string Xoa(int categoryID)
		{
			if (lsp.XoaLSP(categoryID))
			{
				list = lsp.getAllLoaiSP();
				return "Xóa thành công!";
			}
			return "Đã có lỗi xảy ra!";
		}

		public string Sua(LoaiSP loaisp)
		{
			if (lsp.SuaLSP(loaisp))
			{
				list = lsp.getAllLoaiSP();
				return "Cập nhật thành công!";
			}
			return "Đã có lỗi xảy ra!";
		}
	}
}
