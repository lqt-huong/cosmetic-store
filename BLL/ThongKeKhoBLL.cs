using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace BLL
{
	public class ThongKeKhoBLL
	{
		static ThongKeKhoDAL tkkdal;
		static List<ThongKeKho> list;

		public ThongKeKhoBLL()
		{
			tkkdal = new ThongKeKhoDAL();
		}
		//			list = tkkBll.ThongKe();

		public List<ThongKeKho> TimKiem(DateTime bd, DateTime kt)
		{
			return tkkdal.ThongKe(bd, kt);
		}



	}
}
