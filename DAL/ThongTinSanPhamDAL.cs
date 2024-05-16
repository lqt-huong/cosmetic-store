using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace DAL
{
    public class ThongTinSanPhamDAL
    {
		DatabaseConnection databaseConnection = new DatabaseConnection();
		DataTable dataTable;
        public ThongTinSanPhamDAL()
        {
			databaseConnection.OpenDB();

		}
		public List<ProductVariety> GetAllProductVariety()
		{
			List<ProductVariety> listSP = new List<ProductVariety>();
			string querySP = $"select * from ProductVariety where IsDeleted != 1";
			if (!databaseConnection.OpenDB())
				return null;
			dataTable = databaseConnection.RunQuery(querySP);
			ProductVariety TTSanPham;

			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				TTSanPham = new ProductVariety();
				TTSanPham.VarietyID = (int)dataTable.Rows[i]["VarietyID"];
				TTSanPham.ProductID = (int)dataTable.Rows[i]["ProductID"];
				TTSanPham.ProductVolume = (int)dataTable.Rows[i]["Volume"];
				TTSanPham.Price = (int)dataTable.Rows[i]["Price"];
				TTSanPham.Quantity = (int)dataTable.Rows[i]["Quantity"];
				listSP.Add(TTSanPham);
			}
			return listSP;
		}
	}
}
