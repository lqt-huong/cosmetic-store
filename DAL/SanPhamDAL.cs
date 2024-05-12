using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace DAL
{
	public class SanPhamDAL
	{
		DatabaseConnection databaseConnection = new DatabaseConnection();
		DataTable dataTable;
		public SanPhamDAL()
		{
		}

		public List<SanPham> GetAllSP()
		{
			List<SanPham> listSP = new List<SanPham>(); ;
			string querySP = "select * from Product where IsDelete = false";
			//Ket noi false thi tra ve null
			if (!databaseConnection.OpenDB())
				return null;
			dataTable = databaseConnection.RunQuery(querySP);
			SanPham sanPham;

			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				sanPham = new SanPham();

				sanPham.ProductID = (int)dataTable.Rows[i]["ProductID"];
				sanPham.ProductName = dataTable.Rows[i]["ProductName"].ToString();
				sanPham.CategoryID = (int)dataTable.Rows[i]["CategoryID"];
				sanPham.ProviderID = (int)dataTable.Rows[i]["ProviderID"];
			}
			return listSP;
		}

		public bool ThemSP(SanPham sanpham)
		{
			string querySP = "select * from Product";
			dataTable = databaseConnection.RunQuery(querySP);
			DataRow row = dataTable.NewRow();
			row["ProductID"] = sanpham.ProductID;
			row["ProductName"] = sanpham.ProductName;
			row["CategoryID"] = sanpham.CategoryID;
			row["ProviderID"] = sanpham.ProviderID;
			dataTable.Rows.Add(row);
			databaseConnection.Update(dataTable);
			return true;
		}

		public bool SuaSP(SanPham sanpham)
		{
			string querySP = "select* from Product";
			dataTable = databaseConnection.RunQuery(querySP);
			dataTable.PrimaryKey = new DataColumn[]
				{
					dataTable.Columns["ProductID"]
				};
			DataRow row = dataTable.Rows.Find(sanpham.ProductID);
			row["ProductName"] = sanpham.ProductName;
			row["CategoryID"] = sanpham.CategoryID;
			row["ProviderID"] = sanpham.ProviderID;
			databaseConnection.Update(dataTable);
			return true;
		}

		public bool XoaSP(int productID)
		{
			try
			{
				string queryPrVariety = $"update ProductVariety set IsDeleted = 1 where ProductID = '{productID}'";
				databaseConnection.ExecuteNonQuery(queryPrVariety);
				string queryPr = $"update Product set IsDeleted = 1 where ProductID = '{productID}'";
				databaseConnection.ExecuteNonQuery(queryPr);
			}
			catch (Exception ex)
			{
				return false;
			}
			return true;
		}

		public bool KiemTraTrung(int productID)
		{
			string queryPr = $"select * from Product where ProductID = '{productID}'";
			dataTable = databaseConnection.RunQuery(queryPr);
			if (dataTable.Rows.Count > 0) return false;
			return true;
		}

		public int AutoID()
		{
			int id;
			string query = "select max(ProductID) as max_ID from Product";
			dataTable = databaseConnection.RunQuery(query);
			int num = -1;
			if (!int.TryParse(dataTable.Rows[0]["max_ID"].ToString(), out num)) return 1;
			id = (int)dataTable.Rows[0]["max_ID"];
			return id + 1;
		}

		public string getCategoryName(int categoryID)
		{
			string query = $"select CategoryID from Category where CategoryID = '{categoryID}'";
			dataTable = databaseConnection.RunQuery(query);
			return dataTable.Rows[0]["CategoryName"].ToString();
		}

		public string getProviderName(int providerID)
		{
			string query = $"select ProviderName from Provider where ProviderID = '{providerID}'";
			dataTable = databaseConnection.RunQuery(query);
			return dataTable.Rows[0]["ProviderName"].ToString();
		}
	}
}
