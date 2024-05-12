using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace BLL
{
	public class NhaCungCapBLL
	{
		static NhaCungCapDAL ncc;
		static List<NhaCungCap> list;

		public NhaCungCapBLL()
		{
			ncc = new NhaCungCapDAL();
			list = ncc.getAllNCC();
		}
		public List<NhaCungCap> GetAllNCC()
		{
			return ncc.getAllNCC();
		}

		public int AutoID()
		{
			return ncc.AutoID();
		}

		public List<NhaCungCap> TimKiem(string key)
		{
			List<NhaCungCap> listTK = new List<NhaCungCap>();
			foreach (NhaCungCap nc in list)
			{
				if (nc.ProviderName.ToLower().Contains(key.ToLower()))
				{
					list.Add(nc);
				}
			}
			return listTK;
		}


		public bool KiemTraTrung(int providerID)
		{
			return ncc.KiemTraTrung(providerID);
		}

		public string Them(NhaCungCap nhacc)
		{
			nhacc.ProviderID = AutoID();
			if (ncc.Them(nhacc))
			{
				list = ncc.getAllNCC();
				return "Them thanh cong";
			}
			return "Da co loi xay ra!";
		}

		public string Xoa(int providerID)
		{
			if (ncc.Xoa(providerID))
			{
				list = ncc.getAllNCC();
				return "Xóa thành công!";
			}
			return "Đã có lỗi xảy ra!";
		}

		public string Sua(NhaCungCap nhacc)
		{
			if (ncc.Sua(nhacc))
			{
				list = ncc.getAllNCC();
				return "Cập nhật thành công!";
			}
			return "Đã có lỗi xảy ra!";
		}



	}
}
